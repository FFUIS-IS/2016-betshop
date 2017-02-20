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
    class UserRepository
    {
        
        public static void InsertUser(string UserName, string Password)
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

            try
            {

                SqlCeCommand command = new SqlCeCommand(@"INSERT INTO Users (UserName, Password) VALUES (@userName, @password)", Connection);
                command.Parameters.AddWithValue("@userName", UserName);
                command.Parameters.AddWithValue("@password", Password);

                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    command.Dispose();
                    MessageBox.Show("Uspjesno ste dodali igraca!");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        public static bool CheckUnique(string UserName)
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

            bool flag = false;

            try
            {
                SqlCeCommand command = new SqlCeCommand(@"SELECT UserName FROM Users  WHERE @usname = UserName", Connection);
                command.Parameters.AddWithValue("@usname", UserName);
                SqlCeDataReader reader = command.ExecuteReader();

                if (reader.Read() && reader["UserName"].ToString() == UserName)
                {
                    flag = true;
                    MessageBox.Show("Korisničko ime  " + "'" + UserName + "'" + "  već postoji !");
                }

            }

            catch (Exception ex)
            {
                flag = false;
                MessageBox.Show(ex.Message);
            }

            return flag;
        }



        public static bool ChangePassword(int id, string oldPassword, string newPassword, string confirmedNewPassword)
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

            bool flag = false;

            try
            {
                SqlCeCommand command = new SqlCeCommand(@"UPDATE Users SET Password = @pass WHERE Id=@Logged_Id;", Connection);
                command.Parameters.AddWithValue("@Logged_Id", id);
                command.Parameters.AddWithValue("@pass", newPassword);

                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    flag = true;
                    MessageBox.Show("Uspjesno ste promjenili lozinku!!!");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return flag;

        }



        public static int GetIdByName(string name)
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

            SqlCeCommand command = new SqlCeCommand(@"SELECT Id FROM Users WHERE UserName = @name", Connection);
            command.Parameters.AddWithValue("@name", name);
            SqlCeDataReader reader = command.ExecuteReader();

            reader.Read();

            int result = (int)reader["Id"];
            reader.Close();

            return result;
        }
    }
}
