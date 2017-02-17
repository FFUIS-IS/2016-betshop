using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KladionicaProjekat.Models
{
    class Workpeole
    {
        public int Id { get; set; }
        public char First_name { get; set; }
        public char Last_name { get; set; }
        public char Phone_number { get; set; }
        public char Address { get; set; }
        public char Password { get; set; }
        public char Acces_level { get; set; }
        public int User_Id { get; set; }


        public Workpeole(int id, char first_name,  char last_name, char phone_number, char address, char password, char acces_level, int user_Id)
        {
            Id = id;
            First_name = first_name;
            Last_name = last_name;
            Phone_number = phone_number;
            Address = address;
            Password = password;
            Acces_level = acces_level;
            User_Id = user_Id;
        }
    }
}
