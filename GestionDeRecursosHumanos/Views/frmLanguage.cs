﻿    using GestionDeRecursosHumanos;
using GestionDeRecursosHumanos.controller;
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
    public partial class FrmLanguage : Form, Maintainable
    {        
        string globalMode = "0"; //insert = 0; update = 1.

        public FrmLanguage()
        {
            InitializeComponent();
            showData();
        }

        public void showData()
        {
            try
            {
                dgvLanguage.Rows.Clear();
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
                MessageBox.Show("To run this, replace the value of the " +
            "connectionString variable with a connection string that is " +
            "valid for your system. \n " + e.ToString());
            }
        }
       
        public void deleteData(DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvLanguage.Columns[e.ColumnIndex].Name == "ELIMINAR")
                {
                    DialogResult resultDelete = MessageBox.Show("¿Está seguro que quiere eliminar este registro de \n"
                                                    + dgvLanguage.Rows[e.RowIndex].Cells[1].Value.ToString() + " ?", "ATENCIÓN", MessageBoxButtons.YesNo);
                    if (resultDelete == DialogResult.Yes)
                    {
                        SqlCommand command = new SqlCommand("eliminarIdioma", Program.conn.cnn);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = dgvLanguage.Rows[e.RowIndex].Cells[0].Value.ToString();
                        int result = command.ExecuteNonQuery();
                        if (result == -1)
                        {
                            MessageBox.Show("Información borrada.");
                            showData();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void insertUpdateData(string mode)
        {
            SqlCommand command = new SqlCommand("insertarActualizarIdioma", Program.conn.cnn);
            command.CommandType = CommandType.StoredProcedure;

            if (mode  == "0")
            {
                command.Parameters.AddWithValue("@mode", SqlDbType.Char).Value = mode;
                command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = 0;
                command.Parameters.AddWithValue("@name", SqlDbType.VarChar).Value = tbName.Text.Trim();
                command.Parameters.AddWithValue("@descr", SqlDbType.VarChar).Value = tbDescription.Text.Trim();
                int result = command.ExecuteNonQuery();

                if (result == 1)
                {
                    MessageBox.Show("Información guardada.");
                    showData();
                    clearTextBox();               
                }
                else
                {
                    MessageBox.Show("Algo pasó", "No se pudo ejecutar la acción. Favor de revisar su conexión " +
                         "a la Base de Datos o comuníquese con el administrador.");
                }
            }
            else if(mode == "1")
            {
                command.Parameters.AddWithValue("@mode", SqlDbType.Char).Value = mode;
                command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = tbId.Text.Trim();
                command.Parameters.AddWithValue("@name", SqlDbType.VarChar).Value = tbName.Text.Trim();
                command.Parameters.AddWithValue("@descr", SqlDbType.VarChar).Value = tbDescription.Text.Trim();
                int result = command.ExecuteNonQuery();

                if (result == 1)
                {
                    MessageBox.Show("Información guardada.");
                    showData();
                    clearTextBox();
                    btnUpdate.Visible = false;
                    btnAccept.Visible = true;
                    globalMode = "0";
                }
                else
                {
                    MessageBox.Show("Algo pasó", "No se pudo ejecutar la acción. Favor de revisar su conexión " +
                         "a la Base de Datos o comuníquese con el administrador.");
                }
                
            }
          
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            insertUpdateData(globalMode);
        }

        public void clearTextBox()
        {
            tbId.Text = "";
            tbName.Text = "";
            tbDescription.Text = "";
            tbSearch.Text = "";
        }

        private void dgvLanguage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                if (dgvLanguage.Columns[e.ColumnIndex].Name == "EDITAR")
                {
                    globalMode = "1";
                    getDataForUpdate(getDataToTextBox(Convert.ToInt32(dgvLanguage.Rows[e.RowIndex].Cells[0].Value.ToString())));
                    btnUpdate.Visible = true;
                    btnAccept.Visible = false;
                }
                else if (dgvLanguage.Columns[e.ColumnIndex].Name == "ELIMINAR")
                {
                    deleteData(e);
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.ToString());
            }
            
        }

        public DataTable getDataToTextBox(int id)
        {
            SqlCommand command = new SqlCommand("enviarDatosATextBoxIdioma", Program.conn.cnn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = id;
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);

            return dt;
        }

        public void getDataForUpdate(DataTable dt)
        {
            try {
            tbId.Text = dt.Rows[0]["ID"].ToString();
            tbName.Text = dt.Rows[0]["NOMBRE"].ToString();
            tbDescription.Text = dt.Rows[0]["DESCRIPCION"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            insertUpdateData(globalMode);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancelAction();
        }

        public void cancelAction()
        {
            if (btnAccept.Visible) {
                clearTextBox();
            }
            else
            {
                btnUpdate.Visible = false;
                btnAccept.Visible = true;               
                clearTextBox();
                globalMode = "0";
            }
            showData();
        }

        public void search()
        {
            try
            {
                dgvLanguage.Rows.Clear();
                int numRow = 0;
                DataSet ds = new DataSet();

                SqlCommand command = new SqlCommand("obtenerIdiomaLike", Program.conn.cnn);//"Program.conn.cnn" is the connection object.
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@nombreLike", SqlDbType.VarChar).Value = "%" + tbSearch.Text.Trim() + "%";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        dgvLanguage.Rows.Add();
                        dgvLanguage.Rows[numRow].Cells[0].Value = Convert.ToString(row["ID"]);
                        dgvLanguage.Rows[numRow].Cells[1].Value = Convert.ToString(row["NOMBRE"]);
                        dgvLanguage.Rows[numRow].Cells[2].Value = Convert.ToString(row["DESCRIPCION"]);

                        numRow++;
                    }

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            search();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
