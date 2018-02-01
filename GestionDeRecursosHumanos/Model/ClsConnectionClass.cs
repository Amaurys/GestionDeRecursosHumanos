using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace GestionDeRecursosHumanos.Model
{
    class ClsConnectionClass
    {
        string cnnString;
        public SqlConnection cnn;

        public ClsConnectionClass()
        {
            if ((cnn = _cnn()) == null)
            {
                this.Dispose();
            }
        }

        private SqlConnection _cnn()
        {
            SqlConnection conn = null;
            string server = "28FZCH2"; //Server home: Desktop-6PFPSM8; server work: 28FZCH2
            string db = "recursosHumanos";
            //var connectionString = ConfigurationManager.ConnectionStrings["mConnection"].ConnectionString;

            cnnString = string.Format("Server={0};Database={1};Trusted_Connection=true;", server, db);

            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = cnnString /*connectionString*/;
                conn.Open();
                return conn;
            }
            catch
            {
                conn.Dispose();
                return null;
            }
        }
        public void Dispose()
        {
            if (cnn != null)
            {
                cnn.Dispose();
            }
        }
    }
}
