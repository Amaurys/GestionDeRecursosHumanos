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
        }

        public void cancelAction()
        {
            throw new NotImplementedException();
        }

        public void clearTextBox()
        {
            throw new NotImplementedException();
        }

        public void deleteData(DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void getDataForUpdate(DataTable dt)
        {
            throw new NotImplementedException();
        }

        public DataTable getDataToTextBox(int id)
        {
            throw new NotImplementedException();
        }

        public void insertUpdateData(string mode)
        {
            throw new NotImplementedException();
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
                        dgvTraining.Rows[numRow].Cells[0].Value = Convert.ToString(row["ID"]);
                        dgvTraining.Rows[numRow].Cells[1].Value = Convert.ToString(row["NOMBRE"]);
                        dgvTraining.Rows[numRow].Cells[2].Value = Convert.ToString(row["DESCRIPCION"]);
                        dgvTraining.Rows[numRow].Cells[3].Value = Convert.ToString(row["NIVELDETRAINING"]);
                        dgvTraining.Rows[numRow].Cells[4].Value = Convert.ToString(row["FECHAINICIO"]);
                        dgvTraining.Rows[numRow].Cells[5].Value = Convert.ToString(row["FECHAFINALIZO"]);
                        dgvTraining.Rows[numRow].Cells[6].Value = Convert.ToString(row["INSTITUTO"]);
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
            //  tbInstitute.Text = dtpMinSalary.Value.ToString("yyyy/MM/dd"); -- Esto es para 'formatear' el valor del dateTimePicker para enviarlo a la DB.
            //dtpMinSalary.Value = Convert.ToDateTime("2017/01/15"); -- Esto es para 'formatear' el valor de la DB y ponrlo en el dateTimePicker.
        }
    }
}
