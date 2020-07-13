
using NUnit.Framework;
using IterationLib;

namespace IterationTests
{
    public class CountLettersTests
    {
        [TestCase("BABBDDDBECDCDF", "A:1 B:4 C:2 D:5")]
        [TestCase("", "A:0 B:0 C:0 D:0")]
        [TestCase("NEKISEKMGEZZYK", "A:0 B:0 C:0 D:0")]

        public void CountLettersTest(string input, string expected)
        {
            var result = Exercises.CountLetters(input);
            Assert.AreEqual(expected, result);
        }
    }
}