using NUnit.Framework;
using SelectionExercisesLib;
using System;

namespace SelectionExercisesTests
{
    class TicketTypeTests
    {
        [TestCase(100, "OAP")]
        [TestCase(60, "OAP")]
        [TestCase(59, "Standard")]
        [TestCase(18, "Standard")]
        [TestCase(13, "Student")]
        [TestCase(12, "Child")]
        [TestCase(5, "Child")]
        [TestCase(4, "Free")]
        [TestCase(0, "Free")]
        public void TicketTypeTest(int age, string expected)
        {
            var result = Exercises.TicketType(age);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void WhenANegativeAgeIsSpecifiedAnExceptionIsThrown()
        {
            var ex = Assert.Throws<ArgumentException>(() => Exercises.TicketType(-1));
        }

    }
}