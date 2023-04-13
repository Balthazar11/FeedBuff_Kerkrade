using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedBuff_Kerkrade
{
    internal class Feedback
    {
        public int Feedback_ID { get; set; }
        public string Vak { get; set; }
        public string feedback { get; set; }
        public int Weeknr { get; set; } 
        public bool Validated { get; set; }

    }
}
