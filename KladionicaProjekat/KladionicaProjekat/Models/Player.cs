using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KladionicaProjekat.Models
{
    class Player
    {
        public int Id { get; set; }
        public char First_name { get; set; }
        public char Last_name { get; set; }
        public DateTime Date_of_birth { get; set; }
        public int User_Id { get; set; }





        public Player(int id, char first_name, char last_name, DateTime date_of_birth, int user_Id)
        {
            Id = id;
            First_name = first_name;
            Last_name = last_name;
            Date_of_birth = date_of_birth;
            User_Id = user_Id;
        }
    }
}
