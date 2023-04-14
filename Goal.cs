using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedBuff_Kerkrade
{
    internal class Goal
    {
        public int Goal_ID { get; set; }
        public int Weeknr { get; set; }
        public string Goals_Desc { get; set; }
        public List<Task> Tasks { get; set; }
        public Subject Subject { get; set; }

        public Goal(int goalID, int weeknr, string goalsdesc, Subject subject)
        {
            Goal_ID = goalID;
            Weeknr = weeknr;
            Goals_Desc = goalsdesc;
            Tasks = new List<Task>();
            Subject = subject;
        }
    }
}
