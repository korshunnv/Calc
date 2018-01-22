using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalcConsole;

namespace CalcConsoleTest
{
    [TestClass]
    public class CalcTest
    {
        [TestMethod]
        public void TestSum()
        {
            var calc = new Calc();
            var x = 10;
            var y = 1;
            Assert.AreEqual(calc.Sum(x, y), 11);
        }
        [TestMethod]
        public void TestSub()
        {
            var calc = new Calc();
            var x = 10.0;
            var y = 1;
            Assert.AreEqual(calc.Sub(x, y), 9);
        }

        [TestMethod]
        public void TestMult()
        {
            var calc = new Calc();
            var x = 10.0;
            var y = 1;
            Assert.AreEqual(calc.Mult(x, y), 10.0);
        }
        [TestMethod]
        public void TestDiv()
        {
            var calc = new Calc();
            var x = 10.0;
            var y = 1;
            Assert.AreEqual(calc.Div(x, y), 10.0);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivExcaption()
        {
            var calc = new Calc();
            var x = 10.0;
            var y = 0;
            Assert.AreEqual(calc.Div(x,y), new DivideByZeroException());
        }

        [TestMethod]
        public void TestRoot()
        {
            var calc = new Calc();
            var x = 9;
            Assert.AreEqual(calc.Root(x), 3);
        }

        [TestMethod]
        [ExpectedException(typeof(ArithmeticException))]
        public void TestRootExcaption()
        {
            var calc = new Calc();
            var x = -10;
            Assert.AreEqual(calc.Root(x), new ArithmeticException());
        }

        [TestMethod]
        public void TestGeg()
        {
            var calc = new Calc();
            var x = 10;
            var y = 2;
            Assert.AreEqual(calc.Deg(x, y), 100);
        }

        [TestMethod]
        public void TestGegNuN()
        {
            var calc = new Calc();
            var x = -10;
            var y = 0.2;
            Assert.AreEqual(calc.Deg(x, y), double.NaN);
        }

        [TestMethod]
        public void TestGegNegativCorrect()
        {
            var calc = new Calc();
            var x = -10;
            var y = 3;
            Assert.AreEqual(calc.Deg(x, y), -1000);
        }

        [TestMethod]
        public void TestGegZero()
        {
            var calc = new Calc();
            var x = 0.0;
            var y = -3;
            Assert.AreEqual(calc.Deg(x, y), 0.0);
        }
    }
}
