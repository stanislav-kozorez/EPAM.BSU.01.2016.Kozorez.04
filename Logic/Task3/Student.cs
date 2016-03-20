using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Task3
{
    public class Student: Human
    {
        private Training currentTraining;
        public byte Mark { get; set; }
        public Training CurrentTraining { get { return currentTraining; } }
        public bool FinishedTraining { get; set; }

        public Student(string name, string surname) 
            :base(name, surname)
        {

        }

        public void RegisterForATraining(Training t)
        {
            if (t == null)
                throw new ArgumentNullException($"{nameof(t)} is null");
            currentTraining = t;
            FinishedTraining = false;
        }

        public string LearnSomeMaterial()
        {
            return $"Student {this.Name} {this.Surname} has learned some new material.";
        }
    }
}
