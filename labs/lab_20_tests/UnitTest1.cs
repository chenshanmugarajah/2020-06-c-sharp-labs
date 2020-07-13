using NUnit.Framework;
using lab_20_exceptions;
using System;

namespace lab_20_tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(-1)]
        public void Test1(int pos)
        {
            var ex = Assert.Throws<ArgumentException>(() => { Program.AddBeatle(pos, "Brain"); });
            //Assert.AreEqual($"The Beatles do not have a position {pos}", ex.Message, "Exception message not correct");
        }
    }
}