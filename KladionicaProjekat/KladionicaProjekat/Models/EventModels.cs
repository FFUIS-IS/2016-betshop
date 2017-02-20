using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KladionicaProjekat.Models
{
    class EventModels
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Time_of { get; set; }
        public int Doubles_Id { get; set; }


        public EventModels(int id, string date, string time_of, int doubles_Id)
        {
            Id = id;
            Date = date;
            Time_of = time_of;
            Doubles_Id = doubles_Id;
        }
    }
}
