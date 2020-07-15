using NUnit.Framework;
using SafariPark;

namespace SafariTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("Cathy", "French", "Cathy French")]
        [TestCase("", "", " ")]
        public void Test1(string fName, string lName, string expected)
        {
            var instance = new Person(fName, lName);
            var actual = instance.GetFullName();
            Assert.AreEqual(expected, actual);

        }

        [TestCase(12)]
        [TestCase(17)]
        public void AgeTest(int age)
        {
            var instance = new Person() { Age = age };
            Assert.AreEqual(age, instance.Age);
        }

        [TestCase(-1, 0)] //no. of passengers = -1, expect 0
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(3, 3)]
        [TestCase(5, 5)]
        [TestCase(6, 5)] //fail
        public void VehicleCapacityTests(int numPassengers, int expectedPassengers)
        {
            Vehicle v = new Vehicle(5);
            v.NumPassengers = numPassengers;
            Assert.AreEqual(expectedPassengers, v.NumPassengers);
        }

        [Test]
        public void WhenADefaultVehicleMovesTwiceItsPositionIs20()
        {
            Vehicle v = new Vehicle();
            var result = v.Move(2);
            Assert.AreEqual(20, v.Position);
            Assert.AreEqual("Moving along 2 times", result);
        }

        [Test]
        public void WhenAVehicleWithSpeed40IsMovedOnceItsPositionIs40()
        {
            Vehicle v = new Vehicle(5, 40);
            var result = v.Move();
            Assert.AreEqual(40, v.Position);
            Assert.AreEqual("Moving along", result);
        }
    }
}