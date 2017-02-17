using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KladionicaProjekat.Models
{
    class Doubles
    {
        public int Id { get; set; }
        public char Name { get; set; }
        public int Sports_Id { get; set; }





        public Doubles(int id, char name, int sports_Id)
        {
            Id = id;
            Name = name;
            Sports_Id = sports_Id;
        }
    }
}
