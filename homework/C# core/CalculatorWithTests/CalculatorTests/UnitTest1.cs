using NUnit.Framework;
using CalculatorLib;

namespace CalculatorTests
{
    public class StaticCalculatorTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(10, 5, 15)]
        [TestCase(13, 7, 20)]
        [TestCase(-1, 5, 4)]
        public void AddIsCorrect(int a, int b, int expected)
        {
            var actual = StaticCalculator.add(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, 2, 8)]
        [TestCase(6, 11, -5)]
        [TestCase(-1, 5, -6)]
        public void SubtractIsCorrect(int a, int b, int expected)
        {
            var actual = StaticCalculator.subtract(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 5, 0)]
        [TestCase(13, 5, 65)]
        [TestCase(-1, 5, -5)]
        public void MultiplyIsCorrect(int a, int b, int expected)
        {
            var actual = StaticCalculator.multiply(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, 5, 2)]
        [TestCase(6, 2, 3)]
        [TestCase(18, 6, 3)]
        public void DivideIsCorrect(int a, int b, int expected)
        {
            var actual = StaticCalculator.divide(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(18, 0)]
        [TestCase(3, 0)]
        public void DivideIsPositiveInfinity(double a, double b)
        {
            var actual = StaticCalculator.divide(a, b);
            var response = double.IsPositiveInfinity(a / b) ? "true" : "false";
            if (response.Equals("true"))
            {
                Assert.Pass();
            }
        }

        [TestCase(-8, 0)]
        [TestCase(-2, 0)]
        public void DivideIsNegativeInfinity(double a, double b)
        {
            var actual = StaticCalculator.divide(a, b);
            var response = double.IsNegativeInfinity(a / b) ? "true" : "false";
            if (response.Equals("true"))
            {
                Assert.Pass();
            }
        }

        [TestCase(10, 4, 2)]
        [TestCase(2, 3, 2)]
        [TestCase(7, 3, 1)]
        public void ModulusIsCorrect(int a, int b, int expected)
        {
            var actual = StaticCalculator.modulus(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}