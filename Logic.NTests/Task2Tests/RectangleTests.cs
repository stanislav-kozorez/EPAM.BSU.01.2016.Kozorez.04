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
    class RectangleTests
    {
        [TestCase(-3, 0, 1, Result = true)]
        [TestCase(0, -3, 2, Result = true)]
        [TestCase(4, 10, 3, Result = true)]
        [TestCase(10, 4, 4, Result = true)]
        public bool PropertyTest(double a, double b, int testCaseNumber)
        {
            Rectangle r = new Rectangle(a, b);
            if (testCaseNumber < 3)
                return r.A == 5 && r.B == 5;
            else
                if (testCaseNumber == 3)
                    return r.A == 4 && r.B == 10;
                else
                    return r.A == 10 && r.B == 4;
        }


        [Test, TestCase(Result = "Drawing rectangle with legs: a = 20, b = 20")]
        public string DrawTest()
        {
            Rectangle r = new Rectangle(20, 20);
            return r.Draw();
        }

        [TestCase(10, 14, Result = 140)]
        [TestCase(3, 4, Result = 12)]
        public double SquareTest(double a, double b)
        {
            Rectangle r = new Rectangle(a, b);
            return r.Square();
        }

        [TestCase(10, 14, Result = 48)]
        [TestCase(3, 4, Result = 14)]
        public double PerimeterTest(double a, double b)
        {
            Rectangle r = new Rectangle(a, b);
            return r.Perimeter();
        }
    }
}
