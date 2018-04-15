
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
            try
            {
                if (tbUser.Text != "" && tbPassword.Text != "")
                {
                    string password = "";
                    bool isAdmin = true;
                    bool ifExist = false;
                    DataSet ds = new DataSet();
                    mdiParent mdiParent = new mdiParent();

                    SqlCommand command = new SqlCommand("iniciarSesion", Program.conn.cnn);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@user", SqlDbType.VarChar).Value = tbUser.Text.Trim();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    dataAdapter.Fill(ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow row in ds.Tables[0].Rows)
                        {
                            password = row["contrasena"].ToString();
                            if (row["rol"].ToString() == "NO ES ADMINISTRADOR")
                            {
                                isAdmin = false;
                            }
                            mdiParent.lblUserName.Text = "Bienvenido " + row["nombrePila"].ToString();
                        }
                        ifExist = true;
                    }

                    if (ifExist)
                    {
                        if (Cryptography.Decrypt(password).Equals(tbPassword.Text))
                        {
                            mdiParent.Show();
                            if (isAdmin == false)
                            {
                                mdiParent.mantenimientoToolStripMenuItem.Visible = false;
                                mdiParent.registrarUsuarioToolStripMenuItem.Visible = false;
                            }
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("CONTRASEÑA INVALIDA.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("USUARIO NO EXISTE EN LA BASE DE DATOS.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("LOS CAMPOS USUARIO Y/O CONTRASEÑA NO PUEEN ESTAR VACÍOS.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString(),"Error al iniciar sesión.");
            }            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnApplyToVacant_Click(object sender, EventArgs e)
        {
            openFrmJobVacancy();
        }

        private void openFrmJobVacancy()
        {
            FrmJobVacancy jobVacancy = new FrmJobVacancy();
            jobVacancy.Show();
            this.Hide();
        }
    }
}
