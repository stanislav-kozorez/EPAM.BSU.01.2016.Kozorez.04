using System.Drawing;

namespace Logic.Task2
{
    public abstract class Shape
    {
        protected const double DEFAULT_VALUE = 5;

        public abstract string Draw();
        public abstract double Square();
        public abstract double Perimeter();
    }
}
