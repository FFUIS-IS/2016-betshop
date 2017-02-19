using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KladionicaProjekat.Models
{
    class Event_TicketModels
    {
        public string Ticket_Id { get; set; }
        public int Event_Id { get; set; }
        public int Game_type_Id { get; set; }





        public Event_TicketModels(string ticket_Id, int event_Id, int game_type_Id)
        {
            Ticket_Id = ticket_Id;
            Event_Id = event_Id;
            Game_type_Id = game_type_Id;
        }
    }
}
