﻿using GestionDeRecursosHumanos.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeRecursosHumanos.Views
{
    public partial class FrmEmployees : Form, Maintainable
    {
        // static MyMessageBox newMessageBox;
        DataTable myDT = new DataTable();

        public FrmEmployees()
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
                dgvEmployees.Rows.Clear();
                int numRow = 0;
                DataSet ds = new DataSet();

                SqlCommand command = new SqlCommand("obtenerEmpleado", Program.conn.cnn);//"Program.conn.cnn" is the connection object.
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(ds);
                dataAdapter.Fill(myDT);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        dgvEmployees.Rows.Add();
                        dgvEmployees.Rows[numRow].Cells[0].Value = Convert.ToString(row["ID"]);//"ID" is the name of the column in the DB.
                        dgvEmployees.Rows[numRow].Cells[1].Value = Convert.ToString(row["cedula"]);
                        dgvEmployees.Rows[numRow].Cells[2].Value = Convert.ToString(row["nombre"]);
                        dgvEmployees.Rows[numRow].Cells[3].Value = Convert.ToDateTime(row["fechaIngreso"]).ToString("dd/MM/yyyy");
                        dgvEmployees.Rows[numRow].Cells[4].Value = Convert.ToString(row["puesto"]);
                        dgvEmployees.Rows[numRow].Cells[5].Value = Convert.ToString(row["departamento"]);
                        dgvEmployees.Rows[numRow].Cells[6].Value = Convert.ToString(row["salarioMensual"]);

                        if (Convert.ToInt32(row["estado"]) == 1)
                        {
                            dgvEmployees.Rows[numRow].Cells[7].Value = "ACTIVO";
                        }
                        else
                        {
                            dgvEmployees.Rows[numRow].Cells[7].Value = "INACTIVO";
                        }

                        numRow++;
                    }

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void search()
        {
            try
            {
                dgvEmployees.Rows.Clear();
                int numRow = 0;
                DataSet ds = new DataSet();

                SqlCommand command = new SqlCommand("obtenerEmpleadoLike", Program.conn.cnn);//"Program.conn.cnn" is the connection object.
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@nombreLike", SqlDbType.VarChar).Value = "%" + tbSearch.Text.Trim() + "%";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        dgvEmployees.Rows.Add();
                        dgvEmployees.Rows[numRow].Cells[0].Value = Convert.ToString(row["ID"]);//"ID" is the name of the column in the DB.
                        dgvEmployees.Rows[numRow].Cells[1].Value = Convert.ToString(row["cedula"]);
                        dgvEmployees.Rows[numRow].Cells[2].Value = Convert.ToString(row["nombre"]);
                        dgvEmployees.Rows[numRow].Cells[3].Value = Convert.ToDateTime(row["fechaIngreso"]).ToString("dd/MM/yyyy");
                        dgvEmployees.Rows[numRow].Cells[4].Value = Convert.ToString(row["puesto"]);
                        dgvEmployees.Rows[numRow].Cells[5].Value = Convert.ToString(row["departamento"]);
                        dgvEmployees.Rows[numRow].Cells[6].Value = Convert.ToString(row["salarioMensual"]);

                        if (Convert.ToInt32(row["estado"]) == 1)
                        {
                            dgvEmployees.Rows[numRow].Cells[7].Value = "ACTIVO";
                        }
                        else
                        {
                            dgvEmployees.Rows[numRow].Cells[7].Value = "INACTIVO";
                        }

                        numRow++;
                    }

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void viewEmployeeProfile(string cedula)
        {
            FrmViewEmployees frmViewEmployees = new FrmViewEmployees(cedula);
            frmViewEmployees.ShowDialog(this);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            search();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string cedula = dgvEmployees.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            try
            {
                if (dgvEmployees.Columns[e.ColumnIndex].Name == "CEDULA")
                {
                    viewEmployeeProfile(cedula);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void exportar()
        {
            try
            {
                foreach (DataRow row in myDT.Rows)
                {
                    string linea = "";
                    foreach (DataColumn dc in myDT.Columns)
                    {
                        linea += row[dc].ToString() + ",";
                    }
                    writeFileLine(linea);
                }

                Process.Start(@"d:\prueba.csv");

            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
            
        }

        private void writeFileLine(string pLine)
        {
            try
            {
                using (StreamWriter w = File.AppendText("d:\\prueba.csv"))
                {
                    w.WriteLine(pLine);
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
            
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            exportar();
        }
    }
}
