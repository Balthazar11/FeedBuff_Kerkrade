using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FeedBuff_Kerkrade
{
    public class User
    {
        public int User_ID { get; set; }
        public Role Role { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public User(int User_ID, Role role, string Name, string Password)
        {
            this.User_ID = User_ID;
            this.Role = role;
            this.Name = Name;
            this.Password = Password;
        }

        public User(string Name, string Password)
        {
            this.User_ID = -1;
            this.Role = null;
            this.Name = Name;
            this.Password = Password;
        }

        public User(string Name)
        {
            this.Name = Name;
        }
    }
}
