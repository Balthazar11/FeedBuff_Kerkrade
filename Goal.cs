using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedBuff_Kerkrade
{
    public class Goal
    {
        public int Goal_ID { get; set; }
        public int Weeknr { get; set; }
        public string Goals_Desc { get; set; }
        public List<Task> Tasks { get; set; }
        public Subject Subject { get; set; }


        public Goal(int Goal_ID, int weeknr, string Goals_Desc, List<Task> Tasks)
        {
            this.Goal_ID = Goal_ID;
            this.Weeknr = weeknr;
            this.Goals_Desc= Goals_Desc;
            this.Tasks = Tasks;
        }
    }
}
