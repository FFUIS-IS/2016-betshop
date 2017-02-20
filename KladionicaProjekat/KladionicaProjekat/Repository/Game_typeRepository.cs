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
    class Game_typeRepository
    {
        public static string GetKind_of_gameQuery()
        {
            string query;
            query = @"SELECT Kind_of_game FROM  Game_type";
            return query;
        }

        public static bool AddGame_type(string Kind_of_game)
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

            bool flag = false;

            try
            {

                SqlCeCommand command1 = new SqlCeCommand(@"INSERT INTO Game_type (Kind_of_game) VALUES (@kind_of_game)", Connection);
                command1.Parameters.AddWithValue("@kind_of_game", Kind_of_game);

                int result = command1.ExecuteNonQuery();

                if (result > 0)
                {
                    flag = true;
                    MessageBox.Show("Uspjesno ste dodali tip igre!!!");
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
