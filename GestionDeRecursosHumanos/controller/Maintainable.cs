using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeRecursosHumanos.controller
{
    interface Maintainable
    {
        void showData();
        void insertUpdateData(string mode);
        void deleteData(DataGridViewCellEventArgs e);
        DataTable getDataToTextBox(int id);
        void getDataForUpdate(DataTable dt);
        void clearTextBox();
        void cancelAction();
        void search();
    }
}
