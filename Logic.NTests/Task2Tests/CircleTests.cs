using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Logic.Task2;

namespace Logic.NTests.Task2Tests
{
    [TestFixture]
    public class CircleTests
    {
        [TestCase(-4, Result = 5)]
        [TestCase( 0, Result = 5)]
        [TestCase(10, Result = 10)]
        public double RPropertyTest(double r)
        {
            return new Circle(r).R;
        }

        
        [TestCase(10, Result = "Drawing circle with radius: r = 10")]
        public string DrawTest(double r)
        {
            return new Circle(r).Draw();
        }

        [TestCase(-4, Result = true)]
        [TestCase(0, Result = true)]
        [TestCase(10, Result = true)]
        public bool SquareTest(double r)
        {
            if (r == 10)
                return Math.Abs(new Circle(r).Square() - Math.PI * r * r) < 0.001;
            else
                return Math.Abs(new Circle(r).Square() - Math.PI * 25) < 0.001;
        }

        [TestCase(-4, Result = true)]
        [TestCase(0, Result = true)]
        [TestCase(10, Result = true)]
        public bool PerimeterTest(double r)
        {
            if (r == 10)
                return Math.Abs(new Circle(r).Perimeter() - Math.PI * 2 * r) < 0.001;
            else
                return Math.Abs(new Circle(r).Perimeter() - Math.PI * 2 * 5) < 0.001;
        }
    }
}
