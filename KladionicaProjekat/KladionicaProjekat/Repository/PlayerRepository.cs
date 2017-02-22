using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KladionicaProjekat;
using System.Data.SqlServerCe;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;
using System.Data.Common;
using System;
using System.Runtime.Serialization;

namespace KladionicaProjekat.Repository
{
    class PlayerRepository
    {
        public static string GetFirst_nameQuery()
        {
            
            string query;
            query = @"SELECT First_name FROM Player ";
            return query;
        }


        public static string GetLast_nameQuery()
        {
            
            string query;
            query = @"SELECT Last_name FROM Player ";
            return query;
        }

        public static bool AddPlayer(string PlayerFirst_name, string PlayerLast_name, DateTime Date_of_birth, string PlayerUserName, string Password)
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

            bool flag = false;

            try
            {
                UserRepository.InsertUser(PlayerUserName, Password);
                int Player_Id = UserRepository.GetIdByName(PlayerUserName);

                SqlCeCommand command1 = new SqlCeCommand(@"INSERT INTO Workpeople (First_name, Last_name, Date_of_birth, User_Id)
                VALUES (@first_name, @last_name, @date_of_birth, @user_Id)", Connection);
                command1.Parameters.AddWithValue("@firt_name", PlayerFirst_name);
                command1.Parameters.AddWithValue("@last_name", PlayerLast_name);
                command1.Parameters.AddWithValue("@date_of_birth", Date_of_birth);
                command1.Parameters.AddWithValue("@user_Id", Player_Id);

                int result = command1.ExecuteNonQuery();

                if (result > 0)
                {
                    flag = true;
                    MessageBox.Show("Uspjesno ste dodali nastavnika!!!");
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
