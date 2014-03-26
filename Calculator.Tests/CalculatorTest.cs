using System;
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

            Assert.AreEqual(result, expectedResult, "Calculation is not correct for {0}", input);
        }

        [TestCase("2 + 2 * 2", 0)]
        [TestCase("(2 + 2) * 2", 0)]
        [TestCase("2 + 2 / 2", 0)]
        [TestCase("(2 + 2) / 2", 0)]
        public void TestIncorrectCalculations(String input, double expectedResult)
        {
            Calculator calculator = new Calculator();
            double result = calculator.Calculate(input);

            Assert.AreNotEqual(result, expectedResult, "Calculation is not correct for {0}", input);
        }

        [TestCase(" (22 + 2) / 2", 12.0)]
        [TestCase(" (23 + 2) / 2  ", 12.5)]
        public void TestCorrectExpressionsWithSpaces(String input, double expectedResult)
        {
            Calculator calculator = new Calculator();
            double result = calculator.Calculate(input);

            Assert.AreEqual(result, expectedResult, "Calculation is not correct for {0}", input);
        }

        [TestCase("((22 + 2) / 2)", 12.0)]
        [TestCase("((((23 + 2)) / 2))", 12.5)]
        public void TestCorrectExpressionsWithALotOfBraces(String input, double expectedResult)
        {
            Calculator calculator = new Calculator();
            double result = calculator.Calculate(input);

            Assert.AreEqual(result, expectedResult, "Calculation is not correct for {0}", input);
        }

        [TestCase("((22 + 2) / 2", 12.0)]
        [TestCase("(23 + 2)) / 2)))", 12.5)]
        public void TestIncorrectExpressionsWithBraces(String input, double expectedResult)
        {
            Calculator calculator = new Calculator();

            Assert.Throws<InvalidOperationException>(() => calculator.Calculate(input));
        }

        [TestCase("(22 *+ 2) / 2", 12.0)]
        [TestCase("(23 + 2) /+ 2", 12.5)]
        public void TestIncorrectExpressionsWithOperators(String input, double expectedResult)
        {
            Calculator calculator = new Calculator();
            double result = calculator.Calculate(input);

            Assert.Throws<InvalidOperationException>(() => calculator.Calculate(input));
        }
    }
}
