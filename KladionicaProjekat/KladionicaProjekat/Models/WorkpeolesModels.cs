using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KladionicaProjekat.Models
{
    class WorkpeolesModels
    {
        public int Id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Phone_number { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public string Acces_level { get; set; }
        public int User_Id { get; set; }


        public WorkpeolesModels(int id, string first_name, string last_name, string phone_number, string address, string password, string acces_level, int user_Id)
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
