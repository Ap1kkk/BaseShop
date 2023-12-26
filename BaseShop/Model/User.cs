using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPartsShop.Model
{
    [Serializable]
    public class User
    {
        public bool IsAdmin { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }

        public User() { }

        public User(bool isAdmin, string username, string password, string email, string adress)
        {
            IsAdmin = isAdmin;
            Username = username;
            Password = password;
            Email = email;
            Adress = adress;
        }
    }
}
