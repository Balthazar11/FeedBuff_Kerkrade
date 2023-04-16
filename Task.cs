using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedBuff_Kerkrade
{
    public class Task
    {
        public int Task_ID { get; set; }
        public string Task_Desc { get; set; }
        public Goal Goal { get; set; }

        public Task(int taskID, string taskDesc, Goal goal)
        {
            Task_ID = taskID;
            Task_Desc = taskDesc;
            Goal = goal;
        }

    }
}
