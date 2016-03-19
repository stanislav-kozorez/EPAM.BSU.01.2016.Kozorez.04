using System;
using System.Drawing;

namespace Logic.Task2
{
    public class Circle: Shape
    {
        public double r;
        public double R { get { return r; } set { r = value <= 0 ? DEFAULT_VALUE : value; } }

        public Circle(double radius)
        {

            this.r = radius <= 0 ? DEFAULT_VALUE : radius;
        }

        public override string Draw()
        {
            return String.Format("Drawing circle with radius: r = {0}", r);
        }

        public override double Square()
        {
            return Math.PI * r * r;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * r;
        }
    }
}
