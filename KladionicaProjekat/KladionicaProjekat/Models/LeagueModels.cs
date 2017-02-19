using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KladionicaProjekat.Models
{
    class LeagueModels
    {
        public int Id { get; set; }
        public string Type_leagues { get; set; }


        public LeagueModels(int id, string type_leagues)
        {
            Id = id;
            Type_leagues = type_leagues;
        }
    }
}
