using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedBuff_Kerkrade
{
    public class Role
    {
        public int Role_ID { get; set; }
        public string Role_Name { get; set; }


        public Role(int Role_id, string Role_Name)
        {
            this.Role_ID = Role_id;
            this.Role_Name = Role_Name;
        }
    }
}
