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
using System.Data.Common;

namespace KladionicaProjekat.Repository
{
    class WorkpeopleRepository
    {

        public static string GetFirst_nameWorkpeopleQuery()
        {
            
            string query;
            query = @"SELECT First_name FROM Workpeople";
            return query;
        }

        
        public static string GetLast_nameWorkpeopleQuery()
        {
            
            string query;
            query = @"SELECT Last_name FROM Workpeople";
            return query;
        }

        public static int GetIdByName(string First_Name)
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

            SqlCeCommand command = new SqlCeCommand(@"SELECT Id FROM Workpeople WHERE First_Name = @firstName", Connection);
            command.Parameters.AddWithValue(" @firstName", First_Name);
            SqlCeDataReader reader = command.ExecuteReader();

            reader.Read();

            int result = (int)reader["Id"];
            reader.Close();

            return result;
        }

        public static bool AddWorkpeole(string WorkpeoleFirst_name, string WorkpeoleLast_name, string Phone_number, string Address, string Access_level, string WorkpeopleUserName, string Password)
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

            bool flag = false;

            try
            {
                UserRepository.InsertUser(WorkpeopleUserName, Password);
                int Workpeople_Id = UserRepository.GetIdByName(WorkpeopleUserName);

                SqlCeCommand command1 = new SqlCeCommand(@"INSERT INTO Workpeople (First_name, Last_name, Phone_number, Address, Access_level, User_Id)
                VALUES (@first_name, @last_name, @phonenumber, @address, @access_level, @user_Id)", Connection);
                command1.Parameters.AddWithValue("@firt_name", WorkpeoleFirst_name);
                command1.Parameters.AddWithValue("@last_name", WorkpeoleLast_name);
                command1.Parameters.AddWithValue("@phonenumber", Phone_number);
                command1.Parameters.AddWithValue("@address", Address);
                command1.Parameters.AddWithValue("@access_level", Access_level);
                command1.Parameters.AddWithValue("@user_Id", Workpeople_Id);

                int result = command1.ExecuteNonQuery();

                if (result > 0)
                {
                    flag = true;
                    MessageBox.Show("Uspjesno ste dodali radnika!!!");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return flag;
        }

        public static int GetIdByName(string first_name, string last_name)
        {

            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

            int result = -1;

            try
            {
                SqlCeCommand command = new SqlCeCommand(@"SELECT Id FROM Workpeople WHERE First_name = @first_name AND Last_name = @last_name ", Connection);
                command.Parameters.AddWithValue("@first_name", first_name);
                command.Parameters.AddWithValue("@last_name", last_name);
                SqlCeDataReader reader = command.ExecuteReader();

                reader.Read();

                result = (int)reader["Id"];
                reader.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return result;
        }


    }
}
