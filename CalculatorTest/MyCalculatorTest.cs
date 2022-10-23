using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;

namespace CalculatorTest
{
    [TestClass]
    public class MyCalculatorTest
    {
        [TestMethod]
        public void Addition_8and2_10()
        {
            double  a = 8, b = 2, expected = 10;
            char znak = '+';

            double actual = АrithCalculator.Arithmetic(a, b, znak);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Subtraction_10and8_2()
        {
            double a = 10, b = 8, expected = 2;
            char znak = '-';

            double actual = АrithCalculator.Arithmetic(a, b, znak);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Multiplication_10and2_20()
        {
            double a = 10, b = 2, expected = 20;
            char znak = '*';

            double actual = АrithCalculator.Arithmetic(a, b, znak);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Division_18and3_6()
        {
            double a = 18, b = 3, expected = 6;
            char znak = '/';

            double actual = АrithCalculator.Arithmetic(a, b, znak);

            Assert.AreEqual(expected, actual);
        }
    }
}
