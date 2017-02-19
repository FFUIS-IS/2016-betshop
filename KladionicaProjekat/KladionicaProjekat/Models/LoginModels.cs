using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KladionicaProjekat.Models
{
    class LoginModels
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int User_Id { get; set; }

        public LoginModels(int id, string userName, string password, int user_Id)
        {
            Id = id;
            UserName = userName;
            Password = password;
            User_Id = user_Id;
        }
    }
}
