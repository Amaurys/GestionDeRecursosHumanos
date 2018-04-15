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
    public partial class FrmApplicant : Form
    {
        //string position, department;
        int vacancyId;
        public FrmApplicant(int id)
        {
            InitializeComponent();
            //bindComboBoxPosition();
            //bindComboBoxDepartment();
            //bindComboBoxCompetence();
            //this.position = position;
            //this.department = department;
            this.vacancyId = id;
            showData();
        }

        //private void bindComboBoxPosition()
        //{
        //    try
        //    {   
        //        DataSet ds = new DataSet();
        //        SqlCommand command = new SqlCommand("obtenerPuesto", Program.conn.cnn);//"Program.conn.cnn" is the connection object.
        //        command.CommandType = CommandType.StoredProcedure;
        //        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
        //        dataAdapter.Fill(ds);

        //        cbPosition.DataSource = ds.Tables[0];
        //        cbPosition.DisplayMember = "nombre";
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
            
        //}

        //private void bindComboBoxDepartment()
        //{
        //    try
        //    {
        //        DataSet ds = new DataSet();
        //        SqlCommand command = new SqlCommand("obtenerDepartamento", Program.conn.cnn);//"Program.conn.cnn" is the connection object.
        //        command.CommandType = CommandType.StoredProcedure;
        //        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
        //        dataAdapter.Fill(ds);

        //        cbDepartment.DataSource = ds.Tables[0];
        //        cbDepartment.DisplayMember = "nombre";
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
           
        //}

        //private void bindComboBoxCompetence()
        //{
        //    try
        //    {
        //        DataSet ds = new DataSet();
        //        SqlCommand command = new SqlCommand("obtenerCompetencia", Program.conn.cnn);//"Program.conn.cnn" is the connection object.
        //        command.CommandType = CommandType.StoredProcedure;
        //        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
        //        dataAdapter.Fill(ds);

        //        cbCompetences.DataSource = ds.Tables[0];
        //        cbCompetences.DisplayMember = "descripcion";
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
           
        //}

        //private void btnAddCompetence_Click(object sender, EventArgs e)
        //{
        //    addCompetenceComboBoxToDgv();
        //}

        //private void addCompetenceComboBoxToDgv()
        //{
        //    try
        //    {
        //        dgvCompetence.Rows[dgvCompetence.RowCount].Cells[0].Value = cbCompetences.Text;
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.ToString(),"Error");
        //    }
        //}

        public void showData()
        {
            try
            {
                DataSet ds = new DataSet();

                SqlCommand command = new SqlCommand("mostrarVacante", Program.conn.cnn);//"Program.conn.cnn" is the connection object.
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        if (Convert.ToInt32(row["ID"]) == vacancyId)
                        {
                            tbPosition.Text = row["nombreVacante"].ToString();
                            tbDepartment.Text = row["departamento"].ToString();                            
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

        public void saveApplicant()
        {
            SqlCommand command = new SqlCommand("agregarCandidato", Program.conn.cnn);
            command.CommandType = CommandType.StoredProcedure;
            
            command.Parameters.AddWithValue("@cedula", SqlDbType.NVarChar).Value = mtbCedula.Text.Trim();
            command.Parameters.AddWithValue("@nombre", SqlDbType.NVarChar).Value = tbName.Text.Trim();
            command.Parameters.AddWithValue("@puestoAspira", SqlDbType.NVarChar).Value = tbPosition.Text.Trim();
            command.Parameters.AddWithValue("@departamento", SqlDbType.NVarChar).Value = tbDepartment.Text.Trim();
            command.Parameters.AddWithValue("@salarioAspira", SqlDbType.Decimal).Value = Convert.ToDecimal(mtbSalary.Text.Trim());
            command.Parameters.AddWithValue("@recomendado", SqlDbType.NVarChar).Value = tbWhoRecomend.Text.Trim();
            command.Parameters.AddWithValue("@telefono", SqlDbType.NVarChar).Value = mtbTelephone.Text.Trim();
            command.Parameters.AddWithValue("@direccion", SqlDbType.NVarChar).Value = rtbAdress.Text.Trim();
            command.Parameters.AddWithValue("@correo", SqlDbType.NVarChar).Value = tbEmail.Text.Trim();

            int result = command.ExecuteNonQuery();

            if (result == -1)
            {
                MessageBox.Show("Información guardada.");
                showData();
            }
            else
            {
                MessageBox.Show("No se pudo ejecutar la acción. Favor de revisar su conexión " +
                        "a la Base de Datos o comuníquese con el administrador.", "Algo pasó");
            }
        }
        
        private void btnSaveApplicant_Click(object sender, EventArgs e)
        {
            saveApplicant();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void mtbCedula_Leave(object sender, EventArgs e)
        {
            validaCedula(mtbCedula.Text);
        }

        public static bool validaCedula(string pCedula)
        {
            int vnTotal = 0;
            string vcCedula = pCedula.Replace("-", "");
            int pLongCed = vcCedula.Trim().Length;
            int[] digitoMult = new int[11] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1 };

            if (pLongCed < 11 || pLongCed > 11)
                return false;

            for (int vDig = 1; vDig <= pLongCed; vDig++)
            {
                int vCalculo = Int32.Parse(vcCedula.Substring(vDig - 1, 1)) * digitoMult[vDig - 1];
                if (vCalculo < 10)
                    vnTotal += vCalculo;
                else
                    vnTotal += Int32.Parse(vCalculo.ToString().Substring(0, 1)) + Int32.Parse(vCalculo.ToString().Substring(1, 1));
            }

            if (vnTotal % 10 == 0)
            {
                MessageBox.Show("Cédula existe.");
                return true;
            }
            else
            {
                MessageBox.Show("Cédula NO existe.");
                return false;
            }
        }
    }
}
