using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KladionicaProjekat.Models
{
    class Game_type_DoublesModels
    {
        public int Game_type_Id { get; set; }
        public int Doubles_Id { get; set; }
        public float Quota { get; set; }
        public int Hit { get; set; }


        public Game_type_DoublesModels(int game_type_Id, int doubles_Id, float quota, int hit)
        {
            Game_type_Id = game_type_Id;
            Doubles_Id = doubles_Id;
            Quota = quota;
            Hit = hit;
        }
    }
}
