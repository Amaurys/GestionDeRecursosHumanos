using GestionDeRecursosHumanos.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeRecursosHumanos
{
    public partial class mdiParent : Form
    {
        public mdiParent()
        {
            InitializeComponent();
        }

        public void openFormLanguage()
        {
            FrmLanguage frmLanguage = new FrmLanguage();
            frmLanguage.MdiParent = this;
            frmLanguage.Show();
        }

        public void openFormTrainingLevel() {
            FrmTrainingLevel frmTrainingLevel = new FrmTrainingLevel();
            frmTrainingLevel.MdiParent = this;
            frmTrainingLevel.Show();
        }

        public void openFormTraining()
        {
            FrmTraining frmTraining = new FrmTraining();
            frmTraining.MdiParent = this;
            frmTraining.Show();
        }

        private void iToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFormLanguage();
        }

        private void nivelesDeCapacitaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFormTrainingLevel();
        }

        private void capacitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFormTraining();
        }
    }
}
