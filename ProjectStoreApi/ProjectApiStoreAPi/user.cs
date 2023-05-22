using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectStoreApiModels;
using ProjectStoreApiRepository;

namespace ProjectApiStoreAPi
{
    public class User
    {
        
        public string Username { get; set; }
        public string Password { get; set; }
        //public List<Order> Orders { get; set; }

        public user(string username, string password)
        {
            Username = username;
            Password = password;
           // Order = new List<Order>();
        }
    }
}    