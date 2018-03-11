using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionDeRecursosHumanos.Views;

namespace GestionDeRecursosHumanos
{
    static class Program
    {
        public static Model.ClsConnectionClass conn;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            conn = new Model.ClsConnectionClass();//Line added to have de hability of call the connection in all the program. 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());
        }
    }
}
