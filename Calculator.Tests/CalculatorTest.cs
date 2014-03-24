using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;
using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class CalculatorTest
    {
        [TestCase("2 + 2 * 2", 6.0)]
        [TestCase("(2 + 2) * 2", 8.0)]
        [TestCase("2 + 2 / 2", 3.0)]
        [TestCase("(2 + 2) / 2", 2.0)]
        public void TestCorrectCalculations(String input, double expectedResult)
        {
            Calculator calculator = new Calculator();
            double result = calculator.Calculate(input);

            Assert.AreEqual(result, expectedResult, "Wrong calculation");
        }
    }
}
