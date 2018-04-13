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
    public partial class FrmDetailVacancy : Form
    {
        int vacancyId;

        public FrmDetailVacancy(int vacanciyId)
        {
            InitializeComponent();
            this.vacancyId = vacancyId;
        }


    }
}
