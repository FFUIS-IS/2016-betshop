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
    class LoginRepository
    {
        public static void AddLogin(string UserName, string Password, string User_Id)
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

            bool flag = false;

            try
            {
                SqlCeCommand command = new SqlCeCommand(@"INSERT INTO Login (UserName, Password, User_Id) VALUES (@userName, @password, @user_Id)", Connection);
                command.Parameters.AddWithValue("@userName", UserName);
                command.Parameters.AddWithValue("@password", Password);
                command.Parameters.AddWithValue("@user_Id", User_Id);


                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("???");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska!!!");
            }
        }
    }
}
