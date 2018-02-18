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
    public partial class FrmViewEmployees : Form
    {
        String cedula;
        public FrmViewEmployees(string cedulA)
        {
            InitializeComponent();
            this.cedula = cedulA;
            displayData();
            displayJobExperienceInf();
            displayCompetences();
            displayLanguages();
            displayTrainings();
        }

        public void displayData()
        {
            try
            {
                DataTable dt = new DataTable();

                SqlCommand command = new SqlCommand("obtenerEmpleadoConCedula", Program.conn.cnn);//"Program.conn.cnn" is the connection object.
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@cedula", SqlDbType.VarChar).Value = cedula;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    lblId.Text = dt.Rows[0]["id"].ToString();
                    lblCedula.Text = dt.Rows[0]["cedula"].ToString();
                    lblEmployeeName.Text = dt.Rows[0]["nombre"].ToString();
                    lblStartDate.Text = Convert.ToDateTime(dt.Rows[0]["fechaIngreso"]).ToString("dd/MM/yyyy");
                    lblPosition.Text = dt.Rows[0]["puesto"].ToString();
                    lblDepartment.Text = dt.Rows[0]["departamento"].ToString();
                    lblSalary.Text = dt.Rows[0]["salarioMensual"].ToString();

                    if (Convert.ToInt32(dt.Rows[0]["estado"]) == 1) {
                        lblStatus.Text = "ACTIVO";
                    }
                    else
                    {
                        lblStatus.Text = "INACTIVO";
                    }                    
                }                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void displayJobExperienceInf()
        {
            try
            {
                dgvJobExperiencesInformation.Rows.Clear();
                int numRow = 0;
                DataSet ds = new DataSet();

                SqlCommand command = new SqlCommand("obtenerExperienciaLaboraConCedula", Program.conn.cnn);//"Program.conn.cnn" is the connection object.
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@cedula", SqlDbType.VarChar).Value = cedula;

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        dgvJobExperiencesInformation.Rows.Add();
                        dgvJobExperiencesInformation.Rows[numRow].Cells[0].Value = Convert.ToString(row["ID"]);//"ID" is the name of the column in the DB.
                        dgvJobExperiencesInformation.Rows[numRow].Cells[1].Value = Convert.ToString(row["empresa"]);
                        dgvJobExperiencesInformation.Rows[numRow].Cells[2].Value = Convert.ToString(row["puestoOcupado"]);
                        dgvJobExperiencesInformation.Rows[numRow].Cells[3].Value = Convert.ToDateTime(row["fechaDesde"]).ToString("dd/MM/yyyy");
                        dgvJobExperiencesInformation.Rows[numRow].Cells[4].Value = Convert.ToDateTime(row["fechaHasta"]).ToString("dd/MM/yyyy");
                        dgvJobExperiencesInformation.Rows[numRow].Cells[5].Value = Convert.ToString(row["salario"]);
                        dgvJobExperiencesInformation.Rows[numRow].Cells[6].Value = Convert.ToString(row["cedula"]);
                        
                        numRow++;
                    }

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void displayCompetences()
        {//dgvCompetencesEmployees
            try
            {
                dgvCompetencesEmployees.Rows.Clear();
                int numRow = 0;
                DataSet ds = new DataSet();

                SqlCommand command = new SqlCommand("obtenerCompetenciaPersona", Program.conn.cnn);//"Program.conn.cnn" is the connection object.
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@cedula", SqlDbType.VarChar).Value = cedula;

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        dgvCompetencesEmployees.Rows.Add();
                        dgvCompetencesEmployees.Rows[numRow].Cells[0].Value = Convert.ToString(row["descripcion"]);

                        numRow++;
                    }

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void displayLanguages()
        {//dgvLanguageEmployees
            try
            {
                dgvLanguageEmployees.Rows.Clear();
                int numRow = 0;
                DataSet ds = new DataSet();

                SqlCommand command = new SqlCommand("obtenerIdiomaPersona", Program.conn.cnn);//"Program.conn.cnn" is the connection object.
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@cedula", SqlDbType.VarChar).Value = cedula;

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        dgvLanguageEmployees.Rows.Add();
                        dgvLanguageEmployees.Rows[numRow].Cells[0].Value = Convert.ToString(row["nombre"]);

                        numRow++;
                    }

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void displayTrainings()
        {
            try
            {
                dgvTrainingEmployee.Rows.Clear();
                int numRow = 0;
                DataSet ds = new DataSet();

                SqlCommand command = new SqlCommand("obtenerCapacitacionConCedula", Program.conn.cnn);//"Program.conn.cnn" is the connection object.
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@cedula", SqlDbType.VarChar).Value = cedula;

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        dgvTrainingEmployee.Rows.Add();
                        dgvTrainingEmployee.Rows[numRow].Cells[0].Value = Convert.ToString(row["ID"]);//"ID" is the name of the column in the DB.
                        dgvTrainingEmployee.Rows[numRow].Cells[1].Value = Convert.ToString(row["nombre"]);
                        dgvTrainingEmployee.Rows[numRow].Cells[2].Value = Convert.ToString(row["descripcion"]);
                        dgvTrainingEmployee.Rows[numRow].Cells[3].Value = Convert.ToString(row["nivel de capacitacion"]);
                        dgvTrainingEmployee.Rows[numRow].Cells[4].Value = Convert.ToDateTime(row["fechaDesde"]).ToString("dd/MM/yyyy");
                        dgvTrainingEmployee.Rows[numRow].Cells[5].Value = Convert.ToDateTime(row["fechaHasta"]).ToString("dd/MM/yyyy");
                        dgvTrainingEmployee.Rows[numRow].Cells[6].Value = Convert.ToString(row["institucion"]);
                        dgvTrainingEmployee.Rows[numRow].Cells[6].Value = Convert.ToString(row["cedulaTitular"]);

                        numRow++;
                    }

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
