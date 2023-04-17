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
        public string Feedback_Desc { get; set; }
        public int Weeknr { get; set; }
        public bool Validated { get; set; }

        public User user { get; set; }

        public Feedback(string feedbackdesc, int weeknr, bool validated)
        {
            this.Feedback_Desc = feedbackdesc;
            this.Weeknr = weeknr;
            this.Validated = validated;
            this.user = user;
        }

    }
}
