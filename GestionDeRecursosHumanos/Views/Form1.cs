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

        public void openFormDepartment()
        {
            FrmDepartment frmDepartment = new FrmDepartment();
            frmDepartment.MdiParent = this;
            frmDepartment.Show();
        }

        private void openFormJobExperiences()
        {
            FrmJobExperience frmJobExperience = new FrmJobExperience();
            frmJobExperience.MdiParent = this;
            frmJobExperience.Show();
        }
        private void openFormEmployees()
        {
            FrmEmployees frmEmployees = new FrmEmployees();
            frmEmployees.MdiParent = this;
            frmEmployees.Show();
        }
        private void openFormPosition()
        {
            FrmPosition frmPosition = new FrmPosition();
            frmPosition.MdiParent = this;
            frmPosition.Show();
        }
        private void openFrmCompetences()
        {
            FrmCompetence frmCompetence = new FrmCompetence();
            frmCompetence.MdiParent = this;
            frmCompetence.Show();
        }
        private void openFormApplicant()
        {
            FrmApplicant frmApplicant = new FrmApplicant();
            frmApplicant.MdiParent = this;
            frmApplicant.Show();
        }

        private void openFormRegisterUser()
        {
            FrmRegisterUser frmRegisterUser = new FrmRegisterUser();
            frmRegisterUser.MdiParent = this;
            frmRegisterUser.Show();
        }

        private void openFormRiskLevel()
        {
            FrmRiskLevel frmRiskLevel = new FrmRiskLevel();
            frmRiskLevel.MdiParent = this;
            frmRiskLevel.Show();
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

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFormDepartment();
        }

        private void experienciasLaboralesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFormJobExperiences();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFormEmployees();
        }

        private void puestosLaboralesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFormPosition();
        }

        private void cOMPETENCIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFrmCompetences();
        }

        private void candidatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFormApplicant();
        }

        private void registrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFormRegisterUser();
        }

        private void mdiParent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); //With this method the application will exit. 
        }

        private void nivelesDeRiesgoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFormRiskLevel();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            logout();
        }

        private void logout()
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Hide();
        }
    }
}
