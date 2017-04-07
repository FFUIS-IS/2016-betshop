using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KladionicaProjekat;
using System.Data.SqlServerCe;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;

namespace KladionicaProjekat.Repository
{
    class DoublesRepository
    {
        public static string GetNameDoublesQuery()
        {
            string query;
            query = @"SELECT Name FROM Doubles";
            return query;
        }

        public static int GetIdByName(string name)
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

            SqlCeCommand command = new SqlCeCommand(@"SELECT Id FROM Doubles WHERE Name = @name", Connection);
            command.Parameters.AddWithValue("@name", name);
            SqlCeDataReader reader = command.ExecuteReader();

            reader.Read();

            int result = (int)reader["Id"];
            reader.Close();

            return result;
        }

        public static bool AddDoubles(string Name, string Sports_Id)
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

            bool flag = false;

            try
            {

                SqlCeCommand command1 = new SqlCeCommand(@"INSERT INTO Doubles (Name, Sports_Id) VALUES (@name, @sports_Id)", Connection);
                command1.Parameters.AddWithValue("@name", Name);
                command1.Parameters.AddWithValue("@sports_Id", Sports_Id);

                int result = command1.ExecuteNonQuery();

                if (result > 0)
                {
                    flag = true;
                    MessageBox.Show("Uspjesno ste dodali parove!!!");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return flag;
        }
    }
}
