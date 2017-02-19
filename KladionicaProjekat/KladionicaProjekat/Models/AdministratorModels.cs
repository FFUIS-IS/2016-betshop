using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KladionicaProjekat.Models
{
    class AdministratorModels
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int User_Id { get; set; }

        public AdministratorModels(int id, string name, string surName, int user_Id)
        {
            Id = id;
            Name = name;
            SurName = surName;
            User_Id = user_Id;
        }
    }
}
