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
    public partial class FrmDetailVacancy : Form
    {
        int vacancyId;

        public FrmDetailVacancy(int vacancyId)
        {
            InitializeComponent();
            this.vacancyId = vacancyId;
            mostrarVacante();
        }

        public void mostrarVacante()
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
                            lblVacancyName.Text = "Vacante " + row["nombreVacante"].ToString();
                            txtDepartment.Text = row["departamento"].ToString();
                            rtbVacancyDetails.Text = row["detalleVacante"].ToString();
                            tbVacancyDate.Text = row["fechaVacante"].ToString();

                            if (Convert.ToInt16(row["estado"]) == 1)
                            {
                                tbStatus.Text = "Activo";
                            }
                            else
                            {
                                tbStatus.Text = "Inactivo";
                            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmApplicant frmApplicant = new FrmApplicant(vacancyId);
            frmApplicant.ShowDialog();
            this.Close();
        }
    }
}
