using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KladionicaProjekat.Models
{
    class UserModels
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public UserModels(int id, string userName, string password)
        {
            Id = id;
            UserName = userName;
            Password = password;
        }
    }
}
