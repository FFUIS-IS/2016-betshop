using KladionicaProjekat.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KladionicaProjekat
{
    class CheckLogin
    {
        bool flag = false;

        public bool isNewFormOpened()
        {
            return flag;
        }


        public void Check(TextBox Username, TextBox Password)
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;
            if (Username.TextLength > 0 && Password.TextLength > 0)
            {
                try
                {
                    SqlCeCommand logincommand = new SqlCeCommand(@"SELECT * FROM Users WHERE UserName=@uname and Password=@pass", Connection);
                    logincommand.Parameters.AddWithValue("@uname", Username.Text);
                    logincommand.Parameters.AddWithValue("@pass", Password.Text);
                    SqlCeDataReader loginReader = logincommand.ExecuteReader();

                    if (loginReader.Read() &&
                            loginReader["UserName"].ToString() == Username.Text &&
                            loginReader["Password"].ToString() == Password.Text)
                    {
                        SqlCeCommand administratorCommand = new SqlCeCommand(@"SELECT * FROM Administrator WHERE User_Id =@Login_Id", Connection);
                        administratorCommand.Parameters.AddWithValue("@Login_Id", loginReader["Id"]);
                        SqlCeDataReader adminstratorReader = administratorCommand.ExecuteReader(); //Administrator

                        SqlCeCommand playerCommand = new SqlCeCommand(@"SELECT * FROM Player WHERE User_Id =@Login_Id", Connection);
                        playerCommand.Parameters.AddWithValue("@Login_Id", loginReader["Id"]);
                        SqlCeDataReader playerReader = playerCommand.ExecuteReader(); //Igrac

                        SqlCeCommand workpeopleCommand = new SqlCeCommand(@"SELECT * FROM WorkPeople WHERE User_Id =@Login_Id", Connection);
                        workpeopleCommand.Parameters.AddWithValue("@Login_Id", loginReader["Id"]);
                        SqlCeDataReader workpeopleReader = workpeopleCommand.ExecuteReader(); //Radnik

                        UserModels user = new UserModels((int)loginReader["Id"], (string)loginReader["UserName"], (string)loginReader["Password"]);

                        if (adminstratorReader.Read() && user.Id == (int)adminstratorReader["User_Id"])
                        {
                            flag = true;
                            AdministratorModels admin = new AdministratorModels((int)adminstratorReader["Id"], (string)adminstratorReader["Name"], (string)adminstratorReader["SurName"], (int)adminstratorReader["User_Id"]);
                            Form newform = new Pocetna();
                            newform.Show();
                        }
                        else if (playerReader.Read() && user.Id == (int)playerReader["User_Id"])
                        {
                            flag = true;
                            PlayersModels player = new PlayersModels((int)playerReader["Id"], (string)playerReader["First_name"], (string)playerReader["Last_name"], playerReader["Date_of_birth"].ToString(), (int)playerReader["User_Id"]);
                            Form newform = new Pocetna();
                            newform.Show();
                        }
                        else if (workpeopleReader.Read() && user.Id == (int)workpeopleReader["User_Id"])
                        {
                            flag = true;
                            WorkpeolesModels workpeople = new WorkpeolesModels((int)workpeopleReader["Id"], (string)workpeopleReader["First_name"], (string)workpeopleReader["Last_name"], (string)workpeopleReader["Phone_number"], (string)workpeopleReader["Address"], (string)workpeopleReader["Access_level"], (int)workpeopleReader["User_Id"]);
                            Form newform = new Pocetna();
                            newform.Show();
                        }
                        else
                        {
                            flag = false;
                            MessageBox.Show("Netacni podaci");
                        }
                    }
                    else
                    {
                        flag = false;
                        MessageBox.Show("Netacni podaci");
                        Username.Text = "";
                        Password.Text = "";

                    }
                } 
                  catch (Exception ex)
                  {
                      flag = false;
                      MessageBox.Show("Neočekivana greška:" + ex.Message);
                  }
            }
        }
    }
}
