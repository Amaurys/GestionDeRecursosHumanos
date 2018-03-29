using GestionDeRecursosHumanos.controller;
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
    public partial class FrmRiskLevel : Form, Maintainable
    {
        string globalMode = "0";
        public FrmRiskLevel()
        {
            InitializeComponent();
            showData();
        }

        public void cancelAction()
        {
            if (btnAccept.Visible)
            {
                clearTextBox();
            }
            else
            {
                btnUpdate.Visible = false;
                btnAccept.Visible = true;
                clearTextBox();
                globalMode = "0";
            }
            showData();
        }

        public void clearTextBox()
        {
            tbId.Text = "";
            tbName.Text = "";
            tbSearch.Text = "";
        }

        public void deleteData(DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvRiskLevel.Columns[e.ColumnIndex].Name == "ELIMINAR")
                {
                    DialogResult resultDelete = MessageBox.Show("¿Está seguro que quiere eliminar este registro de \n"
                                                    + dgvRiskLevel.Rows[e.RowIndex].Cells[1].Value.ToString() + " ?", "ATENCIÓN", MessageBoxButtons.YesNo);
                    if (resultDelete == DialogResult.Yes)
                    {
                        SqlCommand command = new SqlCommand("eliminarNivelDeRiesgo", Program.conn.cnn);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = dgvRiskLevel.Rows[e.RowIndex].Cells[0].Value.ToString();
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

        public void getDataForUpdate(DataTable dt)
        {
            throw new NotImplementedException();
        }

        public DataTable getDataToTextBox(int id)
        {
            SqlCommand command = new SqlCommand("enviarDatosATextBoxNivelDeRiesgo", Program.conn.cnn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = id;
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);

            return dt;
        }

        public void insertUpdateData(string mode)
        {
            SqlCommand command = new SqlCommand("insertarActualizarNivelDeRiesgo", Program.conn.cnn);
            command.CommandType = CommandType.StoredProcedure;

            if (mode == "0")
            {
                command.Parameters.AddWithValue("@mode", SqlDbType.Char).Value = mode;
                command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = 0;
                command.Parameters.AddWithValue("@name", SqlDbType.VarChar).Value = tbName.Text.Trim();
                int result = command.ExecuteNonQuery();

                if (result == 1)
                {
                    MessageBox.Show("Información guardada.");
                    showData();
                    clearTextBox();
                }
                else
                {
                    MessageBox.Show("Algo pasó", "No se pudo ejecutar la acción. Favor de revisar su conexión " +
                         "a la Base de Datos o comuníquese con el administrador.");
                }
            }
            else if (mode == "1")
            {
                command.Parameters.AddWithValue("@mode", SqlDbType.Char).Value = mode;
                command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = tbId.Text.Trim();
                command.Parameters.AddWithValue("@name", SqlDbType.VarChar).Value = tbName.Text.Trim();
                int result = command.ExecuteNonQuery();

                if (result == 1)
                {
                    MessageBox.Show("Información guardada.");
                    showData();
                    clearTextBox();
                    btnUpdate.Visible = false;
                    btnAccept.Visible = true;
                    globalMode = "0";
                }
                else
                {
                    MessageBox.Show("Algo pasó", "No se pudo ejecutar la acción. Favor de revisar su conexión " +
                         "a la Base de Datos o comuníquese con el administrador.");
                }

            }
        }

        public void search()
        {
            try
            {
                dgvRiskLevel.Rows.Clear();
                int numRow = 0;
                DataSet ds = new DataSet();

                SqlCommand command = new SqlCommand("obtenerNivelDeRiesgoLike", Program.conn.cnn);//"Program.conn.cnn" is the connection object.
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@nombreLike", SqlDbType.VarChar).Value = "%" + tbSearch.Text.Trim() + "%";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        dgvRiskLevel.Rows.Add();
                        dgvRiskLevel.Rows[numRow].Cells[0].Value = Convert.ToString(row["ID"]);
                        dgvRiskLevel.Rows[numRow].Cells[1].Value = Convert.ToString(row["NOMBRE"]);

                        numRow++;
                    }

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("To run this, replace the value of the " +
            "connectionString variable with a connection string that is " +
            "valid for your system. \n " + e.ToString());
            }
        }

        public void showData()
        {
            try
            {
                dgvRiskLevel.Rows.Clear();
                int numRow = 0;
                DataSet ds = new DataSet();

                SqlCommand command = new SqlCommand("obtenerNivelDeRiesgo", Program.conn.cnn);//"Program.conn.cnn" is the connection object.
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        dgvRiskLevel.Rows.Add();
                        dgvRiskLevel.Rows[numRow].Cells[0].Value = Convert.ToString(row["ID"]);
                        dgvRiskLevel.Rows[numRow].Cells[1].Value = Convert.ToString(row["NOMBRE"]);

                        numRow++;
                    }

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("To run this, replace the value of the " +
            "connectionString variable with a connection string that is " +
            "valid for your system. \n " + e.ToString());
            }
        }
    }
}
