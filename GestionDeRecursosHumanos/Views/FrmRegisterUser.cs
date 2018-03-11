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
    public partial class FrmRegisterUser : Form
    {
        public FrmRegisterUser()
        {
            InitializeComponent();
        }

        public void registerUser()
        {
            if (tbFullName.Text != "" && tbUser.Text != "" && tbPassword.Text != "" && tbConfirmPassword.Text != "")
            {
                if (tbPassword.Text.ToString().Trim().ToLower() == tbConfirmPassword.Text.ToString().Trim().ToLower())
                {
                    SqlCommand command = new SqlCommand("insertarUsuario", Program.conn.cnn);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@nombreUsuario", SqlDbType.VarChar).Value = tbUser.Text.Trim();
                    command.Parameters.AddWithValue("@nombrePila", SqlDbType.VarChar).Value = tbFullName.Text.Trim();
                    command.Parameters.AddWithValue("@password", SqlDbType.VarChar).Value = Cryptography.Encrypt(tbPassword.Text.Trim().ToString());

                    if (cbAdmin.Checked)
                    {
                        command.Parameters.AddWithValue("@rol", SqlDbType.VarChar).Value = "ADMINISTRADOR";
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@rol", SqlDbType.VarChar).Value = "NO ES ADMINISTRADOR";
                    }

                    int result = command.ExecuteNonQuery();

                    if (result == -1)
                    {
                        MessageBox.Show("USUARIO REGSITRADO EXITOSAMENTE.");
                        clearTextBox();
                    }
                    else
                    {
                        MessageBox.Show("Algo pasó con la conexión a la base de datos.", "Algo pasó.");

                    }
                }
                else
                {
                    MessageBox.Show("CONTRASEÑA Y CONFIRMAR CONTRASEÑA NO SON IGUALES.",
                                   "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("NO PUEDE DEJAR NINGÚN CAMPO VACÍO. FAVOR DE VERIFICAR QUE TODOS LOS CAMPOS ESTÉN LLENOS.",
                                   "ERROR",MessageBoxButtons.OK,MessageBoxIcon.Information);
                //return;
            }           
        }

        private void clearTextBox()
        {
            tbFullName.Text = "";
            tbUser.Text = "";
            tbPassword.Text = "";
            tbConfirmPassword.Text = "";
            cbAdmin.Checked = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearTextBox();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            registerUser();
        }
    }
}
