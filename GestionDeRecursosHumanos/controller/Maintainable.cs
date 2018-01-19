using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeRecursosHumanos.controller
{
    interface Maintainable
    {
        void showData();
        void insertUpdateData(string mode);
        void deleteData();

    }
}
