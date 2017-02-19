using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KladionicaProjekat.Models
{
    class Code_betting_shopModels
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set;  }





        public Code_betting_shopModels(int id, string name, string address)
        {
            Id = id;
            Name = name;
            Address = address;
        }
    }
}
