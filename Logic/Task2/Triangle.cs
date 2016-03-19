using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Task2
{
    public class Triangle : Shape
    {
        private double a;
        private double b;
        private double c;

        public double A { get { return a; } set { a = value <= 0 ? DEFAULT_VALUE : value; } }
        public double B { get { return b; } set { b = value <= 0 ? DEFAULT_VALUE : value; } }
        public double C { get { return c; } set { c = value <= 0 ? DEFAULT_VALUE : value; } }

        public Triangle(double a, double b, double c)
        {
            this.a = a <= 0 ? DEFAULT_VALUE : a;
            this.b = b <= 0 ? DEFAULT_VALUE : b;
            this.c = c <= 0 ? DEFAULT_VALUE : c;
            if ((this.a + this.b <= this.c) || (this.a + this.c <= this.b) || (this.b + this.c <= this.a))
            {
                this.a = DEFAULT_VALUE;
                this.b = DEFAULT_VALUE;
                this.c = DEFAULT_VALUE;
            }
        }

        public override string Draw()
        {
            return String.Format("Drawing Triangle with legs: a = {0}, b = {1}, c = {2}", a, b, c);
        }

        public override double Square()
        {
            double p = Perimeter()/2.0;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public override double Perimeter()
        {
            return a + b + c;
        }
    }
}
