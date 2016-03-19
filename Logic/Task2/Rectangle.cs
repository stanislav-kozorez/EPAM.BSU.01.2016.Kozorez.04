using System;
using System.Drawing;

namespace Logic.Task2
{
    public class Rectangle: Shape
    {
        private double a;
        private double b;
        
        public double A { get { return a; } set { a = value <= 0 ? DEFAULT_VALUE : value; } }
        public double B { get { return b; } set { b = value <= 0 ? DEFAULT_VALUE : value; } }

        public Rectangle(double a, double b)
        {
            this.a = a <= 0 ? DEFAULT_VALUE : a;
            this.b = b <= 0 ? DEFAULT_VALUE : b;
        }
        public override string Draw()
        {
            return String.Format("Drawing rectangle with legs: a = {0}, b = {1}", a, b);
        }

        public override double Square()
        {
            return a * b;
        }

        public override double Perimeter()
        {
            return (a + b) * 2;
        }
    }
}
