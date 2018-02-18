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
        public FrmApplicant()
        {
            InitializeComponent();
            bindComboBoxPosition();
            bindComboBoxDepartment();
            bindComboBoxCompetence();
        }

        private void bindComboBoxPosition()
        {
            try
            {
                DataSet ds = new DataSet();
                SqlCommand command = new SqlCommand("obtenerPuesto", Program.conn.cnn);//"Program.conn.cnn" is the connection object.
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(ds);

                cbPosition.DataSource = ds.Tables[0];
                cbPosition.DisplayMember = "nombre";
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void bindComboBoxDepartment()
        {
            try
            {
                DataSet ds = new DataSet();
                SqlCommand command = new SqlCommand("obtenerDepartamento", Program.conn.cnn);//"Program.conn.cnn" is the connection object.
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(ds);

                cbDepartment.DataSource = ds.Tables[0];
                cbDepartment.DisplayMember = "nombre";
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        private void bindComboBoxCompetence()
        {
            try
            {
                DataSet ds = new DataSet();
                SqlCommand command = new SqlCommand("obtenerCompetencia", Program.conn.cnn);//"Program.conn.cnn" is the connection object.
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(ds);

                cbCompetences.DataSource = ds.Tables[0];
                cbCompetences.DisplayMember = "descripcion";
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        private void btnAddCompetence_Click(object sender, EventArgs e)
        {
            addCompetenceComboBoxToDgv();
        }

        private void addCompetenceComboBoxToDgv()
        {
            //int index = cbCompetences.FindString
        }
    }
}
