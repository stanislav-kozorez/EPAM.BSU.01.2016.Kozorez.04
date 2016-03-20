using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Task3
{
    public class Training
    {
        private string name;
        private int duration; // weeks
        private DateTime start;
        private Trainer trainer;

        public string Name { get { return name; } set { name = value; } }
        public int Duration { get { return duration; } set { duration = value; } }
        public DateTime Start { get { return start; } set { start = value; } }
        public Trainer Trainer { get { return trainer; } }
        public bool IsClosed { get; set; }

        public Training(string name , int duration, DateTime start, Trainer trainer)
        {
            this.name = name;
            this.duration = duration;
            this.start = start;
            this.trainer = trainer;
        }
    }
}
