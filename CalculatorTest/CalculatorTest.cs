using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;

namespace CalculatorTest
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Arithmetic_8and2_10()
        {
            double  a = 8, b = 2, expected = 10;
            char znak = '+';

            MyCalculator calc = new MyCalculator();
            double actual = calc.Arithmetic(a, b, znak);

            Assert.AreEqual(expected, actual);
        }
    }
}
