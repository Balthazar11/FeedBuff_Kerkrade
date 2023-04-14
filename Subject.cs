using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedBuff_Kerkrade
{
    internal class Subject
    {
        public int Subject_ID { get; set; }
        public string Subject_Name { get; set; }
        public List<Goal> Goals { get; set; }

        public Subject(int subjectID, string subjectName)
        {
            Subject_ID = subjectID;
            Subject_Name = subjectName;
            Goals = new List<Goal>();
        }
    }
}
