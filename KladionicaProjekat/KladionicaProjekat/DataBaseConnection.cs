using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;

using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KladionicaProjekat
{
    class DataBaseConnection
    {
        private static DataBaseConnection instance;

        private SqlCeConnection connection;

        private DataBaseConnection()
        {
            LoginForm LF = new LoginForm();
            string Dir = LF.GetHomeDirectory();
            string connectionString = "Password = 'milos123'; " + "Data Source =" + @Dir + "\\bazakladionice.sdf";


            connection = new SqlCeConnection(connectionString);
            connection.Open();
        }

        public static DataBaseConnection Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataBaseConnection();

                return instance;
            }
        }

        public SqlCeConnection Connection
        {
            get
            {
                return connection;
            }
        }
    }
}
