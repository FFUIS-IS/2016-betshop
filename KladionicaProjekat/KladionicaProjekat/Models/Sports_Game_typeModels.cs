using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KladionicaProjekat.Models
{
    class Sports_Game_typeModels
    {
        public int Sports_Id { get; set; }
        public int Game_type_Id { get; set; }


        public Sports_Game_typeModels(int sports_Id, int game_type_Id)
        {
            Sports_Id = sports_Id;
            Game_type_Id = game_type_Id;
        }
    }
}
