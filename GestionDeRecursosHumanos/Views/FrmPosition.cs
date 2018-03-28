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
    public partial class FrmPosition : Form, Maintainable
    {
        string globalMode = "0";
        public FrmPosition()
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
            mtbMinSalary.Text = "";
            mtbMaxSalary.Text = "";
            cbRiskLevel.SelectedIndex = 1;
            cbStatus.SelectedIndex = 1;
            tbSearch.Text = "";
        }

        public void deleteData(DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvPosition.Columns[e.ColumnIndex].Name == "delete")
                {
                    DialogResult resultDelete = MessageBox.Show("¿Está seguro que quiere eliminar este registro de \n"
                                                    + dgvPosition.Rows[e.RowIndex].Cells[1].Value.ToString() + " ?", "ATENCIÓN", MessageBoxButtons.YesNo);
                    if (resultDelete == DialogResult.Yes)
                    {
                        SqlCommand command = new SqlCommand("eliminarPuesto", Program.conn.cnn);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = dgvPosition.Rows[e.RowIndex].Cells[0].Value.ToString();
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
                cbRiskLevel.SelectedValue = Convert.ToInt32(dt.Rows[0]["idNivelRiesgo"]);
                mtbMinSalary.Text = Convert.ToInt32(dt.Rows[0]["nivelMinimoSalario"]).ToString();//fillSalaryTextBox(dt.Rows[0]["nivelMinimoSalario"].ToString());
                mtbMaxSalary.Text = Convert.ToInt32(dt.Rows[0]["nivlMaximoSalario"]).ToString();//fillSalaryTextBox(dt.Rows[0]["nivlMaximoSalario"].ToString());
                cbStatus.SelectedIndex = Convert.ToInt32(dt.Rows[0]["estado"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public DataTable getDataToTextBox(int id)
        {
            SqlCommand command = new SqlCommand("enviarDatosATextBoxPuesto", Program.conn.cnn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = id;
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);

            return dt;
        }

        public void insertUpdateData(string mode)
        {
            if (compareSalary() == true)
            {
                return;
            }
            else
            {
                try
                {
                    SqlCommand command = new SqlCommand("insertarActualizarPuesto", Program.conn.cnn);
                    command.CommandType = CommandType.StoredProcedure;

                    if (mode == "0")
                    {
                        command.Parameters.AddWithValue("@mode", SqlDbType.Char).Value = mode;
                        command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = 0;
                        command.Parameters.AddWithValue("@name", SqlDbType.VarChar).Value = tbName.Text.Trim();
                        command.Parameters.AddWithValue("@idNivelRiesgo", SqlDbType.Int).Value = cbRiskLevel.SelectedValue;
                        command.Parameters.AddWithValue("@salarioMin", SqlDbType.Decimal).Value = Convert.ToDecimal(mtbMinSalary.Text);
                        command.Parameters.AddWithValue("@salarioMax", SqlDbType.DateTime).Value = Convert.ToDecimal(mtbMaxSalary.Text);

                        if (cbStatus.Text == "ACTIVO")
                        {
                            command.Parameters.AddWithValue("@estado", SqlDbType.Bit).Value = 1;
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@estado", SqlDbType.Bit).Value = 0;
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
                        command.Parameters.AddWithValue("@name", SqlDbType.VarChar).Value = tbName.Text.Trim();
                        command.Parameters.AddWithValue("@idNivelRiesgo", SqlDbType.Int).Value = Convert.ToInt32(cbRiskLevel.SelectedValue);
                        command.Parameters.AddWithValue("@salarioMin", SqlDbType.Decimal).Value = Convert.ToDecimal(mtbMinSalary.Text);//Convert.ToDecimal(fillSalaryTextBox(mtbMinSalary.Text)); //
                        command.Parameters.AddWithValue("@salarioMax", SqlDbType.Decimal).Value = Convert.ToDecimal(mtbMaxSalary.Text); //Convert.ToDecimal(fillSalaryTextBox(mtbMaxSalary.Text)); //

                        if (cbStatus.Text == "ACTIVO")
                        {
                            command.Parameters.AddWithValue("@estado", SqlDbType.Bit).Value = 1;
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@estado", SqlDbType.Bit).Value = 0;
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
        }

        public void showData()
        {
            try
            {
                dgvPosition.Rows.Clear();
                int numRow = 0;
                DataSet ds = new DataSet();

                SqlCommand command = new SqlCommand("obtenerPuesto", Program.conn.cnn);//"Program.conn.cnn" is the connection object.
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(ds);
                
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        dgvPosition.Rows.Add();
                        dgvPosition.Rows[numRow].Cells[0].Value = Convert.ToString(row["ID"]);//"ID" is the name of the column in the DB.
                        dgvPosition.Rows[numRow].Cells[1].Value = Convert.ToString(row["NOMBRE"]);
                        dgvPosition.Rows[numRow].Cells[2].Value = Convert.ToString(row["nivel de riesgo"]);
                        dgvPosition.Rows[numRow].Cells[3].Value = row["nivelMinimoSalario"].ToString();
                        dgvPosition.Rows[numRow].Cells[4].Value = Convert.ToString(row["nivlMaximoSalario"]);

                        if (Convert.ToInt32(row["estado"]) == 1)
                        {
                            dgvPosition.Rows[numRow].Cells[5].Value = "ACTIVO";
                        }
                        else
                        {
                            dgvPosition.Rows[numRow].Cells[5].Value = "INACTIVO";
                        }

                        numRow++;
                    }

                }
                BindComboBox();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void FrmPosition_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nivelesDeRiesgoDataSet.NIVELESRIESGO' table. You can move, or remove it, as needed.
           // this.nIVELESRIESGOTableAdapter.Fill(this.nivelesDeRiesgoDataSet.NIVELESRIESGO);

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            insertUpdateData(globalMode);
        }

        private void dgvPosition_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvPosition.Columns[e.ColumnIndex].Name == "edit")
                {
                    globalMode = "1";
                    getDataForUpdate(getDataToTextBox(Convert.ToInt32(dgvPosition.Rows[e.RowIndex].Cells[0].Value.ToString())));
                    btnUpdate.Visible = true;
                    btnAccept.Visible = false;
                }
                else if (dgvPosition.Columns[e.ColumnIndex].Name == "delete")
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

        private void BindComboBox()
        {
            DataSet ds = new DataSet();
            SqlCommand command = new SqlCommand("obtenerNivelDeRiesgo", Program.conn.cnn);//"Program.conn.cnn" is the connection object.
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(ds);

            cbRiskLevel.DataSource = ds.Tables[0];
            cbRiskLevel.DisplayMember = "nombre";
        }

        //method to validate minimun salary can't be higher than maximun salary
        public bool compareSalary()
        {
            mtbMinSalary.Text.Length.ToString();

            if (Convert.ToDecimal(fillSalaryTextBox(mtbMinSalary.Text))>= Convert.ToDecimal(fillSalaryTextBox(mtbMaxSalary.Text)))
            {
                MessageBox.Show("El SALARIO MÍNIMO no puede ser mayor o igual que el SALARIO MÁXIMO");
                return true;
            }
            else
            {
                return false;
            }
        }

        //method to fill salary textbox with zeros (0)
        private string fillSalaryTextBox(string salary)
        {
            if (salary.Length<8)
            {
                for (int i = 0; salary.Length < 8; i++)
                {
                    salary = "0"+salary;
                }
            }
            return salary;
        }

        public void search()
        {
            try
            {
                dgvPosition.Rows.Clear();
                int numRow = 0;
                DataSet ds = new DataSet();

                SqlCommand command = new SqlCommand("obtenerPuestosLike", Program.conn.cnn);//"Program.conn.cnn" is the connection object.
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@nombreLike", SqlDbType.VarChar).Value = "%" + tbSearch.Text.Trim() + "%";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        dgvPosition.Rows.Add();
                        dgvPosition.Rows[numRow].Cells[0].Value = Convert.ToString(row["ID"]);//"ID" is the name of the column in the DB.
                        dgvPosition.Rows[numRow].Cells[1].Value = Convert.ToString(row["NOMBRE"]);
                        dgvPosition.Rows[numRow].Cells[2].Value = Convert.ToString(row["nivel de riesgo"]);
                        dgvPosition.Rows[numRow].Cells[3].Value = row["nivelMinimoSalario"].ToString();
                        dgvPosition.Rows[numRow].Cells[4].Value = Convert.ToString(row["nivlMaximoSalario"]);

                        if (Convert.ToInt32(row["estado"]) == 1)
                        {
                            dgvPosition.Rows[numRow].Cells[5].Value = "ACTIVO";
                        }
                        else
                        {
                            dgvPosition.Rows[numRow].Cells[5].Value = "INACTIVO";
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
