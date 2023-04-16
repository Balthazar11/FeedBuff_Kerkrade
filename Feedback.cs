using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedBuff_Kerkrade
{
    public class Feedback
    {
        public int Feedback_ID { get; set; }
        public string Vak { get; set; }
        public string feedback { get; set; }
        public int Weeknr { get; set; }
        public bool Validated { get; set; }

        public Feedback(int Feedback_id, string Vak, string Feedback, int Weeknr, bool Validated)
        {
            this.Feedback_ID = Feedback_id;
            this.Vak = Vak;
            this.feedback = Feedback;
            this.Weeknr = Weeknr;
            this.Validated = Validated;

        }
    }
}
