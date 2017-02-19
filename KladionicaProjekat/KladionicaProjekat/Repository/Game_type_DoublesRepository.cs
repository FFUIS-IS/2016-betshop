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
    class Game_type_DoublesRepository
    {
        public static void AddGame_type_Doublese(int Game_type_Id, int Doubles_Id, float Quota, int Hit)
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

            bool flag = false;

            try
            {
                SqlCeCommand command = new SqlCeCommand(@"INSERT INTO Game_type_Doubles (Game_type_Id, Doubles_Id, Quota, Hit) VALUES (@game_type_Id, @doubles_Id, @quota, @hit)", Connection);
                command.Parameters.AddWithValue("@game_type_Id", Game_type_Id);
                command.Parameters.AddWithValue("@doubles_Id", Doubles_Id);
                command.Parameters.AddWithValue("@quota", Quota);
                command.Parameters.AddWithValue("@hit", Hit);


                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Uspjesno ste povezali tip igre  i parove!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska!!!");
            }
        }
    }
}
