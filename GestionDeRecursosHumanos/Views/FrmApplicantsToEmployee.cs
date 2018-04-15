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
    public partial class FrmApplicantsToEmployee : Form
    {
        //int id;
        public FrmApplicantsToEmployee()
        {
            InitializeComponent();
            ShowData();
        }

        private void ShowData()
        {
            try
            {
                dgvApplicant.Rows.Clear();
                int numRow = 0;
                DataSet ds = new DataSet();

                SqlCommand command = new SqlCommand("detallesCandidato", Program.conn.cnn);//"Program.conn.cnn" is the connection object.
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        if (Convert.ToInt16(row["estado"]) == 1)
                        {
                            dgvApplicant.Rows.Add();
                            dgvApplicant.Rows[numRow].Cells[0].Value = Convert.ToString(row["ID"]);
                            dgvApplicant.Rows[numRow].Cells[1].Value = Convert.ToString(row["nombre"]);
                            numRow++;
                        }                       
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

        //public void changeToEmployee()
        //{
        //    SqlCommand command = new SqlCommand("insertarActualizarIdioma", Program.conn.cnn);
        //    command.CommandType = CommandType.StoredProcedure;

        //        command.Parameters.AddWithValue("@mode", SqlDbType.Char).Value = mode;
        //        command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = 0;
        //        command.Parameters.AddWithValue("@name", SqlDbType.VarChar).Value = tbName.Text.Trim();
        //        command.Parameters.AddWithValue("@descr", SqlDbType.VarChar).Value = tbDescription.Text.Trim();
        //        int result = command.ExecuteNonQuery();

        //        if (result == 1)
        //        {
        //            MessageBox.Show("Información guardada.");
        //            ShowData();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Algo pasó", "No se pudo ejecutar la acción. Favor de revisar su conexión " +
        //                 "a la Base de Datos o comuníquese con el administrador.");
        //        }
        //    }

        private void dgvApplicant_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvApplicant.Columns[e.ColumnIndex].Name == "seeRequestField")
                {
                    FrmSaveEmployee frmSaveEmployee = new FrmSaveEmployee(Convert.ToInt32(dgvApplicant.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    frmSaveEmployee.ShowDialog();
                    //frmApplicant.btnSaveApplicant.Visible = false;
                    //frmApplicant.btnSaveEmployee.Visible = true;
                }
                else
                {
                    MessageBox.Show("ERROR");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Error mostrando la vacante.");
            }
        }

        public void search()
        {
            try
            {
                dgvApplicant.Rows.Clear();
                int numRow = 0;
                DataSet ds = new DataSet();

                SqlCommand command = new SqlCommand("detallesCandidatoLike", Program.conn.cnn);//"Program.conn.cnn" is the connection object.
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@nombreLike", SqlDbType.VarChar).Value = "%" + tbSearch.Text.Trim() + "%";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        dgvApplicant.Rows.Add();
                        dgvApplicant.Rows[numRow].Cells[0].Value = Convert.ToString(row["ID"]);
                        dgvApplicant.Rows[numRow].Cells[1].Value = Convert.ToString(row["nombre"]);
                        numRow++;
                    }

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            search();
        }
    }
}
