using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Task3
{
    public abstract class Human
    {
        public string Name { get; }
        public string Surname { get; }

        public Human(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
    }
}
