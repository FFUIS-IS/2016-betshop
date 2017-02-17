using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KladionicaProjekat.Models
{
    class Game_type
    {
        public int Id { get; set; }
        public char Kind_of_game { get; set; }



        public Game_type(int id, char kind_of_game)
        {
            Id = id;
            Kind_of_game = kind_of_game;
        }
    }
}
