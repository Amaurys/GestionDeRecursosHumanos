using GestionDeRecursosHumanos;
using GestionDeRecursosHumanos.controller;
using GestionDeRecursosHumanos.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeRecursosHumanos.Views
{
    public partial class FrmLanguage : Form, Maintainable
    {
        DatabaseConnection dbc = new DatabaseConnection();
        string globalMode = "0";
        public FrmLanguage()
        {
            InitializeComponent();
            showData();
        }

        public void showData()
        {
            try
            {
                dgvLanguage.Rows.Clear();
                int numRow = 0;
                DataSet ds = new DataSet();
                                
                SqlCommand command = new SqlCommand("obtenerIdioma",Program.conn.cnn);//"Program.conn.cnn" is the connection object.
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows) {
                        dgvLanguage.Rows.Add();
                        dgvLanguage.Rows[numRow].Cells[0].Value = Convert.ToString(row["ID"]);
                        dgvLanguage.Rows[numRow].Cells[1].Value = Convert.ToString(row["NOMBRE"]);
                        dgvLanguage.Rows[numRow].Cells[2].Value = Convert.ToString(row["DESCRIPCION"]);
                        numRow++;
                    }
                    
                }                               
            }
            catch(Exception e)
            {
                MessageBox.Show("To run this, replace the value of the " +
            "connectionString variable with a connection string that is " +
            "valid for your system. \n " + e.ToString());
            }
        }
       
        public void deleteData()
        {
            throw new NotImplementedException();
        }

        public void insertUpdateData(string insertMode)
        {
            SqlCommand command = new SqlCommand("insertarActualizarIdioma",Program.conn.cnn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@mode", SqlDbType.Char).Value = insertMode;
            command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = 0;
            command.Parameters.AddWithValue("@name", SqlDbType.VarChar).Value = tbName.Text.Trim();
            command.Parameters.AddWithValue("@descr", SqlDbType.VarChar).Value = tbDescription.Text.Trim();
            int result = command.ExecuteNonQuery();

            if (result == 1)
            {
                MessageBox.Show("Información guardada.");
                showData();
                clearTextBox();               
            }
            else
            {
                MessageBox.Show("Algo pasó.","Algo pasó.");

            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            insertUpdateData(globalMode);
        }

        public void clearTextBox()
        {
            tbName.Text = "";
            tbDescription.Text = "";
        }

        private void dgvLanguage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvLanguage.Columns[e.ColumnIndex].Name=="delete")
                {
                    DialogResult resultDelete = MessageBox.Show("¿Está seguro que quiere eliminar este registro de \n"
                                                    +dgvLanguage.Rows[e.RowIndex].Cells[1].Value.ToString()+" ?","ATENCIÓN",MessageBoxButtons.YesNo);
                    if (resultDelete == DialogResult.Yes)
                    {
                        SqlCommand command = new SqlCommand("eliminarIdioma", Program.conn.cnn);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@id",SqlDbType.Int).Value = dgvLanguage.Rows[e.RowIndex].Cells[0].Value.ToString();
                        int result = command.ExecuteNonQuery();
                        if (result == -1)
                        {
                            MessageBox.Show("Información borrada.");
                            showData();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
