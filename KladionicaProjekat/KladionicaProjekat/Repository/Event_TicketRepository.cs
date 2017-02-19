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
    class Event_TicketRepository
    {
        public static void AddEvent_Ticket(int Event_Id, int Game_type_Id, int Ticket_Id)
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

            bool flag = false;

            try
            {
                SqlCeCommand command = new SqlCeCommand(@"INSERT INTO Event_Ticket (Event_Id, Game_type_Id, Ticket_Id) VALUES (@event_Id, @game_type_Id, @ticket_Id)", Connection);
                command.Parameters.AddWithValue("@event_Id", Event_Id);
                command.Parameters.AddWithValue("@game_type_Id", Game_type_Id);
                command.Parameters.AddWithValue("@ticket_Id", Ticket_Id);


                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Uspjesno ste povezali dogadaj, tiket i tip igre!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska!!!");
            }

        }
    }

}
