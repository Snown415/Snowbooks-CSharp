using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snowbooks_Server.Models
{
    public class User
    {

        private string username { get; set; }
        private string currentIP { get; set; }

        public string Username { get { return username; } set { username = value; } }
        public string CurrentIP { get { return currentIP; } set { currentIP = value; } }

        public User(string username, string ip)
        {
            Username = username;
            CurrentIP = ip;
        }
    }
}
