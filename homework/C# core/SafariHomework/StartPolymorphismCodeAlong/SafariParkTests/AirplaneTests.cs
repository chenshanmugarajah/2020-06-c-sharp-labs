using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Text;
using SafariPark;

namespace SafariParkTests
{
	class AirplaneTests
	{
   
        public void Setup()
        {
        }

        [Test] 

        public void WhenMoveCalledItReturnsCorrectValueAfterAscend500andMove3Times()
        {
            Airplane a = new Airplane(200, 100, "JetsRUs") { NumPassengers = 150 };
            a.Ascend(500);
            a.Move(3);

            var actual = a.Move(3);

            var expected = "Moving along 3 times at an altitude of 500 metres.";
            Assert.AreEqual(expected, actual);
        }

        [Test]

        public void ToStringCorrectWhenAscend500andMove3Times()
        {
            Airplane a = new Airplane(200, 100, "JetsRUs") { NumPassengers = 150 };
            a.Ascend(500);
            a.Move(3);

            var actual = a.ToString();

            var expected = "Thank you for flying JetsRUs: SafariPark.Airplane capacity: 200 passengers: 150 speed: 100 position: 300 altitude: 500.";
            Assert.AreEqual(expected, actual);
        }

        [Test]

        public void WhenMoveCalledItReturnsCorrectValueAfterAscend500Move3TimesDescend200()
        {
            Airplane a = new Airplane(200, 100, "JetsRUs") { NumPassengers = 150 };
            a.Ascend(500);
            a.Move(3);
            a.Descend(200);

            var actual = a.Move();

            var expected = "Moving along at an altitude of 300 metres.";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ToStringCorrectWhenAscend500andMove3TimesDescend200ThenCallMove()
        {
            Airplane a = new Airplane(200, 100, "JetsRUs") { NumPassengers = 150 };
            a.Ascend(500);
            a.Move(3);
            a.Descend(200);
            a.Move();
            a.Move();

            var actual = a.ToString();

            var expected = "Thank you for flying JetsRUs: SafariPark.Airplane capacity: 200 passengers: 150 speed: 100 position: 500 altitude: 300.";
            Assert.AreEqual(expected, actual);
        }
    }
}
