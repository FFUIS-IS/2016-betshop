using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KladionicaProjekat.Models
{
    class DoublesModels
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Sports_Id { get; set; }





        public DoublesModels(int id, string name, int sports_Id)
        {
            Id = id;
            Name = name;
            Sports_Id = sports_Id;
        }
    }
}
