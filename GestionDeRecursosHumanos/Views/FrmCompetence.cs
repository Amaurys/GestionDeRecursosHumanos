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
    public partial class FrmCompetence : Form, Maintainable
    {
        string globalMode = "0"; //insert = 0; update = 1.
        public FrmCompetence()
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
            tbDescription.Text = "";
            tbSearch.Text = "";
        }

        public void deleteData(DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvCompetence.Columns[e.ColumnIndex].Name == "ELIMINAR")
                {
                    DialogResult resultDelete = MessageBox.Show("¿Está seguro que quiere eliminar este registro de \n"
                                                    + dgvCompetence.Rows[e.RowIndex].Cells[1].Value.ToString() + " ?", "ATENCIÓN", MessageBoxButtons.YesNo);
                    if (resultDelete == DialogResult.Yes)
                    {
                        SqlCommand command = new SqlCommand("eliminarCompetencia", Program.conn.cnn);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = dgvCompetence.Rows[e.RowIndex].Cells[0].Value.ToString();
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
                tbDescription.Text = dt.Rows[0]["descripcion"].ToString();
                //cbStatus.SelectedIndex = Convert.ToInt32(dt.Rows[0]["estado"]);
                if (Convert.ToInt32(dt.Rows[0]["ESTADO"]) == 1)
                {
                    cbStatus.SelectedIndex = 0;
                }
                else
                {
                    cbStatus.SelectedIndex = 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            };
        }

        public DataTable getDataToTextBox(int id)
        {
            try
            {
                SqlCommand command = new SqlCommand("enviarDatosATextBoxCompetenciA", Program.conn.cnn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = id;
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        public void insertUpdateData(string mode)
        {
            try
            {
                SqlCommand command = new SqlCommand("insertarActualizarCompetenciA", Program.conn.cnn);
                command.CommandType = CommandType.StoredProcedure;

                if (mode == "0")
                {
                    command.Parameters.AddWithValue("@mode", SqlDbType.Char).Value = mode;
                    command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = 0;
                    command.Parameters.AddWithValue("@descr", SqlDbType.VarChar).Value = tbDescription.Text.Trim();
                    if (cbStatus.SelectedItem.ToString() == "ACTIVO")
                    {
                        command.Parameters.AddWithValue("@status", SqlDbType.Bit).Value = 1;
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@status", SqlDbType.Bit).Value = 0;
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
                        MessageBox.Show("Algo pasó.", "Algo pasó.");

                    }
                }
                else if (mode == "1")
                {
                    command.Parameters.AddWithValue("@mode", SqlDbType.Char).Value = mode;
                    command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = tbId.Text.Trim();
                    command.Parameters.AddWithValue("@descr", SqlDbType.VarChar).Value = tbDescription.Text.Trim();
                    if (cbStatus.SelectedItem.ToString() == "ACTIVO")
                    {
                        command.Parameters.AddWithValue("@status", SqlDbType.Bit).Value = 1;
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@status", SqlDbType.Bit).Value = 0;
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
                        MessageBox.Show("Algo pasó.", "Algo pasó.");

                    }

                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
        }

        public void showData()
        {
            try
            {
                dgvCompetence.Rows.Clear();
                int numRow = 0;
                DataSet ds = new DataSet();

                SqlCommand command = new SqlCommand("obtenerCompetencia", Program.conn.cnn);//"Program.conn.cnn" is the connection object.
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        dgvCompetence.Rows.Add();
                        dgvCompetence.Rows[numRow].Cells[0].Value = Convert.ToString(row["ID"]);
                        dgvCompetence.Rows[numRow].Cells[1].Value = Convert.ToString(row["DESCRIPCION"]);
                        
                        if (Convert.ToInt32(row["ESTADO"]) == 1)
                        {
                            dgvCompetence.Rows[numRow].Cells[2].Value = "ACTIVO";
                        }   
                        else
                        {
                            dgvCompetence.Rows[numRow].Cells[2].Value = "INACTIVO";
                        }
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

        private void btnAccept_Click(object sender, EventArgs e)
        {
            insertUpdateData(globalMode);
        }

        private void dgvCompetence_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvCompetence.Columns[e.ColumnIndex].Name == "EDITAR")
                {
                    globalMode = "1";
                    getDataForUpdate(getDataToTextBox(Convert.ToInt32(dgvCompetence.Rows[e.RowIndex].Cells[0].Value.ToString())));
                    btnUpdate.Visible = true;
                    btnAccept.Visible = false;
                }
                else if (dgvCompetence.Columns[e.ColumnIndex].Name == "ELIMINAR")
                {
                    deleteData(e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancelAction();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            insertUpdateData(globalMode);
        }

        public void search()
        {
            try
            {
                dgvCompetence.Rows.Clear();
                int numRow = 0;
                DataSet ds = new DataSet();

                SqlCommand command = new SqlCommand("obtenerCompetenciaLike", Program.conn.cnn);//"Program.conn.cnn" is the connection object.
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@nombreLike", SqlDbType.VarChar).Value = "%" + tbSearch.Text.Trim() + "%";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        dgvCompetence.Rows.Add();
                        dgvCompetence.Rows[numRow].Cells[0].Value = Convert.ToString(row["ID"]);
                        dgvCompetence.Rows[numRow].Cells[1].Value = Convert.ToString(row["DESCRIPCION"]);

                        if (Convert.ToInt32(row["ESTADO"]) == 1)
                        {
                            dgvCompetence.Rows[numRow].Cells[2].Value = "ACTIVO";
                        }
                        else
                        {
                            dgvCompetence.Rows[numRow].Cells[2].Value = "INACTIVO";
                        }

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
