
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
using OperatorAndMethodsExercisesLib;
using System.Security.Cryptography.X509Certificates;

namespace OperatorsAndMethodsExercisesTests
{
    public class Tests
    {
        [TestCase(5, 2, true)]
        [TestCase(2, 5, false)]
        [TestCase(5, 5, true)]
        public void GivenTwoNumbersXY_GreaterEqual_ReturnsWhetherXIsGreatorOrEqualToY(int x, int y, bool expResult)
        {
            Assert.AreEqual(expResult, Methods.GreaterEqual(x, y));
        }
        [TestCase(11, 0)]
        [TestCase(12, 1)]
        [TestCase(27, 2)]
        [TestCase(0, 0)]
        public void GivenANumberOfEggs_Dozens_ReturnsTheNumberOfDozens(int numEggs, int expResult)
        {
            Assert.AreEqual(expResult, Methods.Dozens(numEggs));
        }
        [TestCase(0, 10.429)]
        [TestCase(10, 24.714)]
        public void GivenNumber_BODMAS_ReturnsTheExpectedResult(int num, double expResult)
        {
            Assert.AreEqual(expResult, Methods.BODMAS(num));
        }

        [TestCase(3, 4, 7, 12)]
        [TestCase(2, -5, -3, -10)]
        public void GivenTwoNumbers_SumProduct_ReturnsTheExpectedResults(int x, int y, int expSum, int expProduct)
        {
            var result = Methods.SumProduct(x, y, out int product);
            Assert.AreEqual(expSum, result);
            Assert.AreEqual(expProduct, product);
        }

        [TestCase(25, 3, 4)]
        [TestCase(0, 0, 0)]
        [TestCase(33, 4, 5)]
        public void GivenANumber_DaysAndWeeks_ReturnsCorrectTuple(
            int totalDays, int expectedWeeks, int expectedDays)
        {
            var answer = Methods.DaysAndWeeks(totalDays);
            Assert.AreEqual(expectedWeeks, answer.weeks, "Weeks");
            Assert.AreEqual(expectedDays, answer.days, "Days");
        }
    }
}