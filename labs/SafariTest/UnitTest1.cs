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
    }
}