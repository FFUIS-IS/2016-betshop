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
    class Sports_Game_typeRepository
    {
        public static void AddSports_Game_type(int Sports_Id, int Game_type_Id)
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

            bool flag = false;

            try
            {
                SqlCeCommand command = new SqlCeCommand(@"INSERT INTO Sports_Game_type (Sports_Id, Game_type_Id) VALUES (@sports_Id, @game_type_Id)", Connection);
                command.Parameters.AddWithValue("@sports_Id", Sports_Id);
                command.Parameters.AddWithValue("@game_type_Id", Game_type_Id);

                
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Uspjesno ste povezali sport i tip igre!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska!!!");
            }
        }
    }
}
