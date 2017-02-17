using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KladionicaProjekat.Models
{
    class League
    {
        public int Id { get; set; }
        public char Type_leagues { get; set; }


        public League(int id, char type_leagues)
        {
            Id = id;
            Type_leagues = type_leagues;
        }
    }
}
