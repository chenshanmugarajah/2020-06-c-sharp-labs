using System;
using NUnit.Framework;
using IterationLib;

namespace IterationTests
{
    class SumEvenFiveTests
    {
        [TestCase(0, 0)]
        [TestCase(1, 0)]
        [TestCase(9, 25)]
        [TestCase(10, 35)]
        [TestCase(22, 152)]
        public void SumEvenFiveTest(int n, int expectedSum)
        {
            var result = Exercises.SumEvenFive(n);
            Assert.AreEqual(expectedSum, result);
        }
    }
}