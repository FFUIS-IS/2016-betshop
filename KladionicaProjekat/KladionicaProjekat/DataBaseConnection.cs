using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;

namespace KladionicaProjekat
{
    class DataBaseConnection
    {
        private static DataBaseConnection instance;

        private SqlCeConnection connection;

        private DataBaseConnection()
        {
            Pocetna Pc = new Pocetna();
            string Dir = Pc.GetHomeDirectory();
            string connectionString = "Password = 'milos123'; " + "Data Source ='" + @Dir + "\\bazakladionice.sdf'";


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
