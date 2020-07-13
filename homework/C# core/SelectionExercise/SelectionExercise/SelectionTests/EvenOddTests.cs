
using NUnit.Framework;
using SelectionExercisesLib;

namespace SelectionExercisesTests
{
    public class EvenOddTests
    {
        [TestCase(-2)]
        [TestCase(0)]
        [TestCase(2)]
        [TestCase(348)]
        public void WhenTheNumberIsEvenTheResultIsTrue(int x)
        {
            var result = Exercises.EvenOdd(x);
            Assert.IsTrue(result);
        }

        [TestCase(-3)]
        [TestCase(-1)]
        [TestCase(1)]
        [TestCase(347)]
        public void WhenTheNumberIsOddTheResultIsFalse(int x)
        {
            var result = Exercises.EvenOdd(x);
            Assert.IsFalse(result);
        }
    }
}