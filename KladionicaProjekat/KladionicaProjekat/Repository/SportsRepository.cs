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
    class SportsRepository
    {
        public static bool AddSports(string Description_sports, string League_Id)
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

            bool flag = false;

            try
            {

                SqlCeCommand command1 = new SqlCeCommand(@"INSERT INTO Sports (Description_sports, League_Id) VALUES (@description_sports, @league_Id)", Connection);
                command1.Parameters.AddWithValue("@description_sports", Description_sports);
                command1.Parameters.AddWithValue("@league_Id", League_Id);

                int result = command1.ExecuteNonQuery();

                if (result > 0)
                {
                    flag = true;
                    MessageBox.Show("Uspjesno ste dodali sport!!!");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Greska!!!");
            }

            return flag;
        }
    }
}
