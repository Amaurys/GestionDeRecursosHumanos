using GestionDeRecursosHumanos;
using GestionDeRecursosHumanos.Model;
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
    public partial class FrmLanguage : Form
    {
        DatabaseConnection dbc = new DatabaseConnection();

        public FrmLanguage()
        {
            InitializeComponent();
            showData();
        }

        public void showData()
        {
            try
            {
                int numRow = 0;
                DataSet ds = new DataSet();
                                
                SqlCommand command = new SqlCommand("obtenerIdioma",Program.conn.cnn);//"Program.conn.cnn" is the connection object.
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows) {
                        dgvLanguage.Rows.Add();
                        dgvLanguage.Rows[numRow].Cells[0].Value = Convert.ToString(row["ID"]);
                        dgvLanguage.Rows[numRow].Cells[1].Value = Convert.ToString(row["NOMBRE"]);
                        dgvLanguage.Rows[numRow].Cells[2].Value = Convert.ToString(row["DESCRIPCION"]);
                        numRow++;
                    }
                    
                }                               
            }
            catch(Exception e)
            {
                MessageBox.Show("To run this example, replace the value of the " +
            "connectionString variable with a connection string that is " +
            "valid for your system. \t" + e.ToString());
            }
        }
    }
}
