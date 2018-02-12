using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionDeRecursosHumanos.controller;
using System.Data.SqlClient;

namespace GestionDeRecursosHumanos.Views
{
    public partial class FrmTraining : Form,Maintainable
    {
        string globalMode = "0";

        public FrmTraining()
        {
            InitializeComponent();
            showData();
            dtpStartDate.CustomFormat = "dd/MM/yyyy";
            dtpFinishDate.CustomFormat = "dd/MM/yyyy";
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
        }

        public void clearTextBox()
        {
            tbId.Text = "";
            tbName.Text = "";
            tbDescription.Text = "";
            dtpStartDate.Value = DateTime.Today;
            dtpFinishDate.Value = DateTime.Today;
            tbInstitute.Text = "";
            mtbCedula.Text = "";
        }

        public void deleteData(DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvTraining.Columns[e.ColumnIndex].Name == "delete")
                {
                    DialogResult resultDelete = MessageBox.Show("¿Está seguro que quiere eliminar este registro de \n"
                                                    + dgvTraining.Rows[e.RowIndex].Cells[1].Value.ToString() + " ?", "ATENCIÓN", MessageBoxButtons.YesNo);
                    if (resultDelete == DialogResult.Yes)
                    {
                        SqlCommand command = new SqlCommand("eliminarCapacitacion", Program.conn.cnn);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = dgvTraining.Rows[e.RowIndex].Cells[0].Value.ToString();
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
            try
            {
                tbId.Text = dt.Rows[0]["ID"].ToString();
                tbName.Text = dt.Rows[0]["NOMBRE"].ToString();
                tbDescription.Text = dt.Rows[0]["DESCRIPCION"].ToString();
                cbTrainingLevel.SelectedIndex = Convert.ToInt32(dt.Rows[0]["idNivelCapacitacion"]);
                dtpStartDate.Value = Convert.ToDateTime(dt.Rows[0]["fechaDesde"]);
                dtpFinishDate.Value = Convert.ToDateTime(dt.Rows[0]["fechaHasta"]);
                tbInstitute.Text = dt.Rows[0]["institucion"].ToString();
                mtbCedula.Text = dt.Rows[0]["cedulaTitular"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public DataTable getDataToTextBox(int id)
        {
            SqlCommand command = new SqlCommand("enviarDatosATextBoxCap", Program.conn.cnn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = id;
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);

            return dt;
        }

        public void insertUpdateData(string mode)
        {
            SqlCommand command = new SqlCommand("insertarActualizarCapacitacion", Program.conn.cnn);
            command.CommandType = CommandType.StoredProcedure;

            if (mode == "0")
            {
                command.Parameters.AddWithValue("@mode", SqlDbType.Char).Value = mode;
                command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = 0;
                command.Parameters.AddWithValue("@name", SqlDbType.VarChar).Value = tbName.Text.Trim();
                command.Parameters.AddWithValue("@descr", SqlDbType.VarChar).Value = tbDescription.Text.Trim();
                command.Parameters.AddWithValue("@idNivelCapacitacion", SqlDbType.Int).Value = cbTrainingLevel.ValueMember;
                command.Parameters.AddWithValue("@fechaDesde", SqlDbType.DateTime).Value = dtpStartDate.Value.ToString();
                command.Parameters.AddWithValue("@fechaHasta", SqlDbType.DateTime).Value = dtpFinishDate.Value.ToString("yyyy/MM/dd");
                command.Parameters.AddWithValue("@institucion", SqlDbType.VarChar).Value = tbInstitute.Text.Trim();
                command.Parameters.AddWithValue("@cedularTitular", SqlDbType.VarChar).Value = mtbCedula.Text.Trim();
                int result = command.ExecuteNonQuery();

                if (result == 1)
                {
                    MessageBox.Show("Información guardada.");
                    showData();
                    clearTextBox();
                }
                else
                {
                    MessageBox.Show("Algo pasó.", "Algo pasó.");

                }
            }
            else if (mode == "1")
            {
                command.Parameters.AddWithValue("@mode", SqlDbType.Char).Value = mode;
                command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = 0;
                command.Parameters.AddWithValue("@name", SqlDbType.VarChar).Value = tbName.Text.Trim();
                command.Parameters.AddWithValue("@descr", SqlDbType.VarChar).Value = tbDescription.Text.Trim();
                command.Parameters.AddWithValue("@idNivelCapacitacion", SqlDbType.Int).Value = cbTrainingLevel.SelectedValue;
                command.Parameters.AddWithValue("@fechaDesde", SqlDbType.DateTime).Value = dtpStartDate.Value.ToString("dd/MM/yyyy");
                command.Parameters.AddWithValue("@fechaHasta", SqlDbType.DateTime).Value = dtpFinishDate.Value.ToString("dd/MM/yyyy");
                command.Parameters.AddWithValue("@institucion", SqlDbType.VarChar).Value = tbInstitute.Text.Trim();
                command.Parameters.AddWithValue("@cedularTitular", SqlDbType.VarChar).Value = mtbCedula.Text.Trim();
                int result = command.ExecuteNonQuery();
                Console.WriteLine(dtpStartDate.Value);
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
                    MessageBox.Show("Algo pasó.", "Algo pasó.");

                }

            }
        }

        public void showData()
        {
            try
            {
                dgvTraining.Rows.Clear();
                int numRow = 0;
                DataSet ds = new DataSet();

                SqlCommand command = new SqlCommand("obtenerCapacitacion", Program.conn.cnn);//"Program.conn.cnn" is the connection object.
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        dgvTraining.Rows.Add();
                        dgvTraining.Rows[numRow].Cells[0].Value = Convert.ToString(row["ID"]);//"ID" is the name of the column in the DB.
                        dgvTraining.Rows[numRow].Cells[1].Value = Convert.ToString(row["NOMBRE"]);
                        dgvTraining.Rows[numRow].Cells[2].Value = Convert.ToString(row["DESCRIPCION"]);
                        dgvTraining.Rows[numRow].Cells[3].Value = Convert.ToString(row["nivel de capacitacion"]);
                        dgvTraining.Rows[numRow].Cells[4].Value = Convert.ToDateTime(row["fechaDesde"]).ToString("dd/MM/yyyy");
                        dgvTraining.Rows[numRow].Cells[5].Value = Convert.ToDateTime(row["fechaHasta"]).ToString("dd/MM/yyyy");
                        dgvTraining.Rows[numRow].Cells[6].Value = Convert.ToString(row["institucion"]);
                        dgvTraining.Rows[numRow].Cells[7].Value = Convert.ToString(row["cedulaTitular"]);
                        numRow++;
                    }

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void FrmTraining_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'recursosHumanosDataSet.NIVELESCAPACITACIONES' table. You can move, or remove it, as needed.
            this.nIVELESCAPACITACIONESTableAdapter.Fill(this.recursosHumanosDataSet.NIVELESCAPACITACIONES);

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            //tbInstitute.Text = dtpMinSalary.Value.ToString("yyyy/MM/dd"); --Esto es para 'formatear' el valor del dateTimePicker para enviarlo a la DB.
            //dtpMinSalary.Value = Convert.ToDateTime("2017/01/15"); -- Esto es para 'formatear' el valor de la DB y ponrlo en el dateTimePicker.
            insertUpdateData(globalMode);
        }

        private void dgvTraining_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvTraining.Columns[e.ColumnIndex].Name == "edit")
                {
                    globalMode = "1";
                    getDataForUpdate(getDataToTextBox(Convert.ToInt32(dgvTraining.Rows[e.RowIndex].Cells[0].Value.ToString())));
                    btnUpdate.Visible = true;
                    btnAccept.Visible = false;
                }
                else if (dgvTraining.Columns[e.ColumnIndex].Name == "delete")
                {
                    deleteData(e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            insertUpdateData(globalMode);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancelAction();
        }
    }
}
