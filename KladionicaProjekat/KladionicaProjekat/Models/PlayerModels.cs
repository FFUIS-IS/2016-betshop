using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KladionicaProjekat.Models
{
    class PlayersModels
    {
        public int Id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Date_of_birth { get; set; }
        public int User_Id { get; set; }


        public PlayersModels(int id, string first_name, string last_name, string date_of_birth, int user_Id)
        {
            Id = id;
            First_name = first_name;
            Last_name = last_name;
            Date_of_birth = date_of_birth;
            User_Id = user_Id;
        }
    }
}
