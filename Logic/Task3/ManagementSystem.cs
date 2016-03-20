using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Task3
{
    public static class ManagementSystem
    {
        private static readonly List<Trainer> trainers = new List<Trainer>();
        private static readonly List<Student> students = new List<Student>();

        public static List<Trainer> Trainers { get { return Trainers; } }
        public static List<Student> Students { get { return students; } }

        public static void RegisterNewStudent(string name, string surname)
        {
            if (name == null)
                throw new ArgumentNullException($"{nameof(name)} is null");
            if (surname == null)
                throw new ArgumentNullException($"{nameof(surname)} is null");
            students.Add(new Student(name, surname));
        }

        public static void RegisterNewTrainer(string name, string surname)
        {
            if (name == null)
                throw new ArgumentNullException($"{nameof(name)} is null");
            if (surname == null)
                throw new ArgumentNullException($"{nameof(surname)} is null");
            trainers.Add(new Trainer(name, surname));
        }


    }
}
