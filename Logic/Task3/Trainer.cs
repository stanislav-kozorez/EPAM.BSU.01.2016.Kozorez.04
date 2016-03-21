using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Task3
{
    public class Trainer: Human
    {
        public Trainer(string name, string surname)
            : base(name, surname) { }

        public void AnnounceNewTraining(string trainingName, int duration, DateTime start)
        {
            if (trainingName == null)
                throw new ArgumentNullException($"{nameof(trainingName)}");

            ManagementSystem.AddTraining(trainingName, duration, start, this);
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
            Random r = new Random();

            training.IsClosed = true;
            foreach (var student in training.GetStudents())
                AssignAGradeTo(student, (byte)r.Next(1, 11));
            ManagementSystem.AddTrainingToArchive(training);
        }

    }
}
