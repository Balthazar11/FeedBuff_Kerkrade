using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedBuff_Kerkrade
{
    public class Subject
    {
        public int Subject_ID { get; set; }
        public string Subject_Name { get; set; }

        public Subject( string subjectName)
        {
            this.Subject_ID = -1;
            this.Subject_Name = subjectName;
        }
    }
}
