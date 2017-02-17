using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KladionicaProjekat.Models
{
    class Administrator
    {
        public int Id { get; set; }
        public char Name { get; set; }
        public char SurName { get; set; }
        public int User_Id { get; set; }

        public Administrator(int id, char name, char surName, int user_Id)
        {
            Id = id;
            Name = name;
            SurName = surName;
            User_Id = user_Id;
        }
    }
}
