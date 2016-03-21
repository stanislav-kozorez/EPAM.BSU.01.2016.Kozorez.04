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
        private static readonly List<Training> currentTrainings = new List<Training>();
        private static readonly List<Training> archiveTrainings = new List<Training>();

        public static List<Trainer> Trainers { get { return new List<Trainer>(trainers); } }
        public static List<Student> Students { get { return new List<Student>(students); } }
        public static List<Training> CurrentTrainings { get { return new List<Training>(currentTrainings); } }
        public static List<Training> ArchiveTrainings { get { return new List<Training>(archiveTrainings); } }
        public static void AddTraining(string trainingName, int duration, DateTime start, Trainer trainer)
        {
            currentTrainings.Add(new Training(trainingName, duration, start, trainer));
        }

        public static void RemoveTraining(Training t)
        {
            if (t == null)
                throw new ArgumentNullException("t is null");
            if (currentTrainings.Contains(t))
                currentTrainings.Remove(t);           
        }

        internal static void AddTrainingToArchive(Training training)
        {
            archiveTrainings.Add(training);
            currentTrainings.Remove(training);
        }

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
