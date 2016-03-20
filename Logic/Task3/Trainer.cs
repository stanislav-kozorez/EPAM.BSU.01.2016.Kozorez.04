using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Task3
{
    public class Trainer: Human
    {
        private List<Training> trainings;

        public Trainer(string name, string surname)
            : base(name, surname)
        {
            trainings = new List<Training>();
        }

        public List<Training> Trainings { get { return trainings; } }

        public void AnnounceNewTraining(string trainingName, int duration, DateTime start)
        {
            if (trainingName == null)
                throw new ArgumentNullException($"{nameof(trainingName)}");

            trainings.Add(new Training(trainingName, duration, start, this));
        }
        
        public void AssignAGradeTo(Student student, byte mark)
        {
            if (student == null)
                throw new ArgumentNullException($"{nameof(student)} is null");
            student.FinishedTraining = true;
            student.Mark = mark;
        }

        /// <summary>
        /// Training is closed after all students get their marks
        /// </summary>
        public void CloseTraining(Training training)
        {
            training.IsClosed = true;
        }

    }
}
