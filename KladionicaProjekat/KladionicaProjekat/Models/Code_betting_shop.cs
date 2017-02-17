using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KladionicaProjekat.Models
{
    class Code_betting_shop
    {
        public int Id { get; set; }
        public char Name { get; set; }
        public char Address { get; set;  }





        public Code_betting_shop(int id, char name, char address)
        {
            Id = id;
            Name = name;
            Address = address;
        }
    }
}
