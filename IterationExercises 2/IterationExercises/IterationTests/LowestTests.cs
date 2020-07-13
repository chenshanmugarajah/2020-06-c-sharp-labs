using NUnit.Framework;
using IterationLib;

namespace IterationTests
{
    public class LowestTests
    {
        [Test]
        public void LowestTest()
        {
            int[] nums = { 3, 7, 1, 8, 5000 };
            var result = Exercises.Lowest(nums);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void WhenTheArrayIsEmptyLowestReturnsMax()
        {
            int[] nums = { };
            var result = Exercises.Lowest(nums);
            Assert.AreEqual(int.MaxValue, result);
        }

        public void WhenTheArrayContainsEmptyValuesLowestReturnsCorrectResultMax()
        {
            int[] nums = { 550, -291, 43, -55 };
            var result = Exercises.Lowest(nums);
            Assert.AreEqual(-291, result);
        }
    }
}