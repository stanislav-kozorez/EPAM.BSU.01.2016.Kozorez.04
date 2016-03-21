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
        private int duration;
        private DateTime start;
        private DateTime end;
        private Trainer trainer;
        private List<Student> students;

        public string Name { get { return name; } set { name = value; } }
        public int Duration { get { return duration; } set { duration = value; } }
        public DateTime Start { get { return start; } set { start = value; } }
        public DateTime End { get { return end; } set { end = value; } }
        public Trainer Trainer { get { return trainer; } }
        public bool IsClosed { get; set; }

        public Training(string name , int monthsDuration, DateTime start, Trainer trainer)
        {
            this.name = name;
            this.duration = monthsDuration;
            this.start = start;
            this.trainer = trainer;
            this.end = start.AddMonths(monthsDuration);
            this.students = new List<Student>();
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(obj, null))
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != typeof(Training))
                return false;
            Training t = (Training)obj;

            return this.name == t.name && this.start == t.start && this.end == t.end;
        }

        public void AddStudent(Student s)
        {
            students.Add(s);
        }

        public List<Student> GetStudents()
        {
            return students;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return start.GetHashCode() ^ end.GetHashCode() ^ (duration * 100);
            }         
        }
    }
}
