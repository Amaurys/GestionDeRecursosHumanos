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
    public partial class FrmJobVacancy : Form
    {
        int vacancyId;
        public FrmJobVacancy()
        {
            InitializeComponent();
            showVacancy();
        }

        public void showVacancy()
        {
            try
            {
                dgvVacancy.Rows.Clear();
                int numRow = 0;
                DataSet ds = new DataSet();

                SqlCommand command = new SqlCommand("mostrarVacante", Program.conn.cnn);//"Program.conn.cnn" is the connection object.
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        dgvVacancy.Rows.Add();
                        dgvVacancy.Rows[numRow].Cells[0].Value = Convert.ToString(row["ID"]);
                        dgvVacancy.Rows[numRow].Cells[1].Value = Convert.ToString(row["nombreVacante"]);
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

        private void dgvVacancy_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvVacancy.Columns[e.ColumnIndex].Name == "seeRequestField")
                {
                    FrmDetailVacancy detailVacancy = new FrmDetailVacancy(Convert.ToInt32(dgvVacancy.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    detailVacancy.ShowDialog();
                }
                else
                {
                    MessageBox.Show("ERROR");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(),"Error mostrando la vacante.");
            }           
        }
    }
}
