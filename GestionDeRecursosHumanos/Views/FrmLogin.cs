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
using GestionDeRecursosHumanos.controller;

namespace GestionDeRecursosHumanos.Views
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void login()
        {
            if (tbUser.Text != "" && tbPassword.Text != "")
            {
                string password = "";
                bool isExist = false;

                SqlCommand command = new SqlCommand("iniciarSesion", Program.conn.cnn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@user", SqlDbType.VarChar).Value = tbUser.Text.Trim();

                SqlDataReader sdr = command.ExecuteReader();
                if (sdr.Read())
                {
                    password = sdr.GetString(3);
                    isExist = true;
                }

                if (isExist)
                {
                    if (Cryptography.Decrypt(password).Equals(tbPassword))
                    {
                        mdiParent mdiParent = new mdiParent();
                        mdiParent.Show();
                        this.Dispose();
                    }
                }
                else
                {
                    MessageBox.Show("CONTRASEÑA INCORRECTA.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("USUARIO O CONTRASEÑA INVALIDOS.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
