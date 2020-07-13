using NUnit.Framework;
using DataTypesPt2Lib;
using System;

namespace DataTypesPt2Tests
{
    public class Tests
    {
        [Test]
        public void GivenValidDate_AgeAt_ReturnsCorrectAge()
        {
            var birthDate = new DateTime(1992, 4, 21);
            var date = new DateTime(2020, 5, 27);
            var result = Methods.AgeAt(birthDate, date);
            Assert.AreEqual(28, result);
        }

        [Test]
        public void GivenHaventHadBirthdayYet_AgeAt_ReturnsCorrectAge()
        {
            var birthDate = new DateTime(1992, 8, 21);
            var date = new DateTime(2020, 5, 27);
            var result = Methods.AgeAt(birthDate, date);
            Assert.AreEqual(27, result);
        }

        [Test]
        public void IfDateIsAfterBirthdate_AgeAt_ThrowsException()
        {
            var birthDate = new DateTime(1992, 8, 21);
            var date = new DateTime(1992, 5, 27);
            var ex = Assert.Throws<ArgumentException>(() => Methods.AgeAt(birthDate, date));
            Assert.AreEqual("Error - birthDate is in the future", ex.Message);
        }

        [Test]
        public void GivenADateTimeObject_FormatDate_ReturnsAFormattedString()
        {
            var date = new DateTime(2020, 11, 16);
            var result = Methods.FormatDate(date);
            Assert.AreEqual("20/16/Nov", result);
        }

        [Test]
        public void GivenADateTimeObject_GetMonthString_ReturnsTheCorrectMonth()
        {
            var date = new DateTime(2020, 11, 16);
            var result = Methods.GetMonthString(date);
            Assert.AreEqual("November", result);
        }

        [TestCase(Suit.CLUBS, "And the seventh rule is if this is your first night at fight club, you have to fight.")]
        [TestCase(Suit.DIAMONDS, "Diamonds are a girls best friend")]
        [TestCase(Suit.HEARTS, "You've broken my heart")]
        [TestCase(Suit.SPADES, "Bucket and spade")]
        public void GivenASuit_Fortune_ReturnsAnAppropriateMethod(Suit suit, string expectedMessage)
        {
            var result = Methods.Fortune(suit);
            Assert.AreEqual(result, expectedMessage);
        }
    }
}