using GestionDeRecursosHumanos.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeRecursosHumanos.Views
{
    public partial class FrmJobExperience : Form, Maintainable
    {
        public FrmJobExperience()
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
            throw new NotImplementedException();
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
