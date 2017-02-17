using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KladionicaProjekat.Models
{
    class Event
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time_of { get; set; }
        public int Doubles_Id { get; set; }


        public Event(int id, DateTime date, DateTime time_of, int doubles_Id)
        {
            Id = id;
            Date = date;
            Time_of = time_of;
            Doubles_Id = doubles_Id;
        }
    }
}
