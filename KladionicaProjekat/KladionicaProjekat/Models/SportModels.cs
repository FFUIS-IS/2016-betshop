using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KladionicaProjekat.Models
{
    class SportsModels
    {
        public int Id { get; set; }
        public string Description_sports { get; set; }
        public int League_Id { get; set; }


        public SportsModels(int id, string description_sports, int league_Id)
        {
            Id = id;
            Description_sports = description_sports;
            League_Id = league_Id;
        }
    }
}
