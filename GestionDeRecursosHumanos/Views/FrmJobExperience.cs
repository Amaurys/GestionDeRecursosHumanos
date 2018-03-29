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
    public partial class FrmJobExperience : Form, Maintainable
    {
        string globalMode = "0"; //insert = 0; update = 1.

        public FrmJobExperience()
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
            tbCompany.Text = "";
            tbOccuppedPosition.Text = "";
            mtbCedula.Text = "";
            dtpBeginDate.Value = DateTime.Today;
            dtpFinishDate.Value = DateTime.Today;
            mtbSalary.Text = "";
            tbSearch.Text = "";
        }

        public void deleteData(DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvJobExperiences.Columns[e.ColumnIndex].Name == "ELIMINAR")
                {
                    DialogResult resultDelete = MessageBox.Show("¿Está seguro que quiere eliminar este registro de \n"
                                                    + dgvJobExperiences.Rows[e.RowIndex].Cells[1].Value.ToString() + " ?", "ATENCIÓN", MessageBoxButtons.YesNo);
                    if (resultDelete == DialogResult.Yes)
                    {
                        SqlCommand command = new SqlCommand("eliminarExperienciaLaboral", Program.conn.cnn);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = dgvJobExperiences.Rows[e.RowIndex].Cells[0].Value.ToString();
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
                tbCompany.Text = dt.Rows[0]["empresa"].ToString();
                tbOccuppedPosition.Text = dt.Rows[0]["puestoOcupado"].ToString();
                dtpBeginDate.Value = Convert.ToDateTime(dt.Rows[0]["fechaDesde"]);
                dtpFinishDate.Value = Convert.ToDateTime(dt.Rows[0]["fechaHasta"]);
                mtbSalary.Text = Convert.ToInt32(dt.Rows[0]["salario"]).ToString();
                mtbCedula.Text = dt.Rows[0]["cedula"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public DataTable getDataToTextBox(int id)
        {
            SqlCommand command = new SqlCommand("enviarDatosATextBoxExperienciaLaboral", Program.conn.cnn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = id;
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);

            return dt;
        }

        public void insertUpdateData(string mode)
        {
            try{
                SqlCommand command = new SqlCommand("insertarActualizarExperienciaLaboral", Program.conn.cnn);
                command.CommandType = CommandType.StoredProcedure;

                if (mode == "0")
                {
                    command.Parameters.AddWithValue("@mode", SqlDbType.Char).Value = mode;
                    command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = 0;
                    command.Parameters.AddWithValue("@company", SqlDbType.VarChar).Value = tbCompany.Text.Trim();
                    command.Parameters.AddWithValue("@positionOccupied", SqlDbType.VarChar).Value = tbOccuppedPosition.Text.Trim();
                    command.Parameters.AddWithValue("@beginDate", SqlDbType.DateTime).Value = dtpBeginDate.Value;
                    command.Parameters.AddWithValue("@finishDate", SqlDbType.DateTime).Value = dtpFinishDate.Value;
                    command.Parameters.AddWithValue("@salary", SqlDbType.Decimal).Value = Convert.ToDecimal(mtbSalary.Text);
                    command.Parameters.AddWithValue("@cedula", SqlDbType.VarChar).Value = mtbCedula.Text.Trim();

                    //comparando las fechas de inicio y final
                    if (dtpFinishDate.Value < dtpBeginDate.Value)
                    {
                        MessageBox.Show("LA FECHA DE INICIO NO PUEDE SER MAYOR A LA FECHA DE FINALIZACIÓN.",
                                            "ERROR EN LAS FECHAS");
                        return;
                    }
                    //validating if salary is less or equals to zero
                    if (Convert.ToDecimal(mtbSalary.Text) <= 0)
                    {
                        MessageBox.Show("EL SALARIO NO PUEDE SER MENOR O IGUAL QUE CERO (0).","ERROR EN EL SALARIO");
                        return;
                    }

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
                    command.Parameters.AddWithValue("@company", SqlDbType.VarChar).Value = tbCompany.Text.Trim();
                    command.Parameters.AddWithValue("@positionOccupied", SqlDbType.VarChar).Value = tbOccuppedPosition.Text.Trim();
                    command.Parameters.AddWithValue("@beginDate", SqlDbType.DateTime).Value = dtpBeginDate.Value;
                    command.Parameters.AddWithValue("@finishDate", SqlDbType.DateTime).Value = dtpFinishDate.Value;
                    command.Parameters.AddWithValue("@salary", SqlDbType.Decimal).Value = Convert.ToDecimal(mtbSalary.Text);
                    command.Parameters.AddWithValue("@cedula", SqlDbType.VarChar).Value = mtbCedula.Text.Trim();

                    //comparando las fechas de inicio y final
                    if (dtpFinishDate.Value < dtpBeginDate.Value)
                    {
                        MessageBox.Show("LA FECHA DE INICIO NO PUEDE SER MAYOR A LA FECHA DE FINALIZACIÓN.",
                                            "ERROR EN LAS FECHAS");
                        return;
                    }
                    //validating if salary is less or equals to zero
                    if (Convert.ToDecimal(mtbSalary.Text) <= 0)
                    {
                        MessageBox.Show("EL SALARIO NO PUEDE SER MENOR O IGUAL QUE CERO (0).", "ERROR EN EL SALARIO");
                        return;
                    }

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
            } catch (Exception e) { MessageBox.Show(e.ToString()); }

           
        }

        public void showData()
        {
            try
            {
                dgvJobExperiences.Rows.Clear();
                int numRow = 0;
                DataSet ds = new DataSet();

                SqlCommand command = new SqlCommand("obtenerExperienciaLaboral", Program.conn.cnn);//"Program.conn.cnn" is the connection object.
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        dgvJobExperiences.Rows.Add();
                        dgvJobExperiences.Rows[numRow].Cells[0].Value = Convert.ToString(row["ID"]);//"ID" is the name of the column in the DB.
                        dgvJobExperiences.Rows[numRow].Cells[1].Value = Convert.ToString(row["empresa"]);
                        dgvJobExperiences.Rows[numRow].Cells[2].Value = Convert.ToString(row["puestoOcupado"]);
                        dgvJobExperiences.Rows[numRow].Cells[3].Value = Convert.ToDateTime(row["fechaDesde"]).ToString("dd/MM/yyyy");
                        dgvJobExperiences.Rows[numRow].Cells[4].Value = Convert.ToDateTime(row["fechaHasta"]).ToString("dd/MM/yyyy");
                        dgvJobExperiences.Rows[numRow].Cells[5].Value = Convert.ToString(row["salario"]);
                        dgvJobExperiences.Rows[numRow].Cells[6].Value = Convert.ToString(row["cedula"]);
                        numRow++;
                    }

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            insertUpdateData(globalMode);
        }

        private void dgvJobExperiences_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvJobExperiences.Columns[e.ColumnIndex].Name == "edit")
                {
                    globalMode = "1";
                    getDataForUpdate(getDataToTextBox(Convert.ToInt32(dgvJobExperiences.Rows[e.RowIndex].Cells[0].Value.ToString())));
                    btnUpdate.Visible = true;
                    btnAccept.Visible = false;
                }
                else if (dgvJobExperiences.Columns[e.ColumnIndex].Name == "ELIMINAR")
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

        public void search()
        {
            try
            {
                dgvJobExperiences.Rows.Clear();
                int numRow = 0;
                DataSet ds = new DataSet();

                SqlCommand command = new SqlCommand("obtenerExperienciaLaboralLike", Program.conn.cnn);//"Program.conn.cnn" is the connection object.
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@nombreLike", SqlDbType.VarChar).Value = "%" + tbSearch.Text.Trim() + "%";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        dgvJobExperiences.Rows.Add();
                        dgvJobExperiences.Rows[numRow].Cells[0].Value = Convert.ToString(row["ID"]);//"ID" is the name of the column in the DB.
                        dgvJobExperiences.Rows[numRow].Cells[1].Value = Convert.ToString(row["empresa"]);
                        dgvJobExperiences.Rows[numRow].Cells[2].Value = Convert.ToString(row["puestoOcupado"]);
                        dgvJobExperiences.Rows[numRow].Cells[3].Value = Convert.ToDateTime(row["fechaDesde"]).ToString("dd/MM/yyyy");
                        dgvJobExperiences.Rows[numRow].Cells[4].Value = Convert.ToDateTime(row["fechaHasta"]).ToString("dd/MM/yyyy");
                        dgvJobExperiences.Rows[numRow].Cells[5].Value = Convert.ToString(row["salario"]);
                        dgvJobExperiences.Rows[numRow].Cells[6].Value = Convert.ToString(row["cedula"]);
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
