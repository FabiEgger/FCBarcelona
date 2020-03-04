using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Website_FCBarcelona.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Firstname { get; set; }
 
        public string Username { get; set; }
        public string Password { get; set; }

        public string Password2 { get; set; }

        public User() : this(0, "", "", "", "") { }

        public User(int id, string firstname, string username, string password, string password2)
        {
            this.ID = id;
            this.Firstname = firstname;
            this.Username = username;
            this.Password = password;
            this.Password2 = password2;
        }

        //ToString()
    }
}