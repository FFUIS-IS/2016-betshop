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
    class TicketRepository
    {
        public static void AddTicket(DateTime Date_of_payment, DateTime Time_payment, string Ticket_control_number, float Payment_amount, int Player_Id, int Workpeople_Id, int Code_betting_shop_Id, string System)
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

            bool flag = false;

            try
            { 
                SqlCeCommand command = new SqlCeCommand(@"INSERT INTO Ticket (Date_of_payment, Time_payment, Ticket_control_number, Payment_amount, Player_Id, Workpeople_Id, Code_betting_shop_Id, System)
                VALUES (@date_of_payment, @time_payment, @ticket_control_number, @payment_amount, @player_Id, @workpeople_Id, @code_betting_shop_Id, @system)", Connection);
                command.Parameters.AddWithValue("@date_of_pyament", Date_of_payment);
                command.Parameters.AddWithValue("@time_payment", Time_payment);
                command.Parameters.AddWithValue("@ticket_control_number", Ticket_control_number);
                command.Parameters.AddWithValue("@payment_amount", Payment_amount);
                command.Parameters.AddWithValue("@player_id", Player_Id);
                command.Parameters.AddWithValue("@workpeople_Id", Workpeople_Id);
                command.Parameters.AddWithValue("@code_betting_shop_Id", Code_betting_shop_Id);
                command.Parameters.AddWithValue("@system", System);
                


                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Uspjesno dodali tiket!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska!!!");
            }
        }
    }
}
