using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KladionicaProjekat.Models
{
    class Game_typeModels
    {
        public int Id { get; set; }
        public string Kind_of_game { get; set; }



        public Game_typeModels(int id, string kind_of_game)
        {
            Id = id;
            Kind_of_game = kind_of_game;
        }
    }
}
