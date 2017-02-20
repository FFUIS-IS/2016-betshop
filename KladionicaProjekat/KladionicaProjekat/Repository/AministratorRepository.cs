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
    class AministratorRepository
    {
        

        public static bool AddAdministrator(string AdministratorName, string AdministratorSurName, string AdministratorUserName, string Password)
        {

            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

            bool flag = false;

            try
            {
                UserRepository.InsertUser(AdministratorUserName, Password);
                int Adminstrator_Id = UserRepository.GetIdByName(AdministratorUserName);

                SqlCeCommand command = new SqlCeCommand(@"INSERT INTO Administration (Name, SurName, User_Id) VALUES (@name, @surName, @user_Id)", Connection);
                command.Parameters.AddWithValue("@name", AdministratorName);
                command.Parameters.AddWithValue("@surName", AdministratorName);
                command.Parameters.AddWithValue("@user_Id", Adminstrator_Id);

                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    command.Dispose();
                    flag = true;
                    MessageBox.Show("Uspjesno ste dodali administratora!!!");
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
