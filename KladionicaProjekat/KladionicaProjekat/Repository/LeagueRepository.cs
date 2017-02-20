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
    class LeagueRepository
    {
        public static string GetQuery()
        {
            string query;
            query = @"SELECT Type_leagues FROM League";
            return query;
        }
        public static bool AddLeague(string Type_leagues)
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

            bool flag = false;

            try
            {

                SqlCeCommand command1 = new SqlCeCommand(@"INSERT INTO League (Type_leagues) VALUES (@type_leagues)", Connection);
                command1.Parameters.AddWithValue("@type_leagues", Type_leagues);

                int result = command1.ExecuteNonQuery();

                if (result > 0)
                {
                    flag = true;
                    MessageBox.Show("Uspjesno ste dodali vrstu lige!!!");
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
