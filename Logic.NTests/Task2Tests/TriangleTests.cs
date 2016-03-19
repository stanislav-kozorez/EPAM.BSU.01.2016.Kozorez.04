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
    class TriangleTests
    {        
        [TestCase(-3, 0, 4, 1, Result = true)]
        [TestCase(0, -3, 4, 2, Result = true)]
        [TestCase(4, 0, -3, 3, Result = true)]
        [TestCase(4, 6, 10, 4, Result = true)]
        [TestCase(10, 4, 6, 5, Result = true)]
        [TestCase(6, 10, 4, 6, Result = true)]
        [TestCase(15, 20, 6, 7, Result = true)]
        [TestCase(6, 15, 20, 8, Result = true)]
        [TestCase(20, 6, 15, 9, Result = true)]
        public bool PropertyTest(double a, double b, double c, int testCaseNumber)
        {
            Triangle t = new Triangle(a, b, c);

            if(testCaseNumber < 3)
                return t.A == 5 && t.B == 5 && t.C == 4;
            if(testCaseNumber == 3)
                return t.A == 4 && t.B == 5 && t.C == 5;
            if (testCaseNumber < 7)
                return t.A == 5 && t.B == 5 && t.C == 5;
            if(testCaseNumber == 7)
                return t.A == 15 && t.B == 20 && t.C == 6;
            if(testCaseNumber == 8)
                return t.A == 6 && t.B == 15 && t.C == 20;
            else 
                return t.A == 20 && t.B == 6 && t.C == 15;
        }

       
        [Test, TestCase(Result= "Drawing Triangle with legs: a = 14, b = 11, c = 10")]
        public string DrawTest()
        {
            Triangle t = new Triangle(14, 11, 10);
            return t.Draw();
        }

        [TestCase(10, 14, 20, Result = true)]
        [TestCase(3, 4, 5, Result = true)]
        public bool SquareTest(double a, double b, double c)
        {
            Triangle t = new Triangle(a, b, c);
            return Math.Abs(t.Square() - Math.Sqrt((a+b+ c)/2 *((a + b + c) / 2 - a) * ((a + b + c) / 2 - b) * ((a + b + c) / 2 - c)))< 0.001;
        }

        [TestCase(10, 14, 20, Result = 44)]
        [TestCase(3, 4, 5, Result = 12)]
        public double PerimeterTest(double a, double b, double c)
        {
            Triangle t = new Triangle(a, b, c);
            return t.Perimeter();
        }

    }
}
