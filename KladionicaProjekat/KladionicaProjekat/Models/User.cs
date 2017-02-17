using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KladionicaProjekat.Models
{
    class User
    {
        public int Id { get; set; }
        public char UserName { get; set; }
        public char Password { get; set; }

        public User(int id, char userName, char password)
        {
            Id = id;
            UserName = userName;
            Password = password;
        }
    }
}
