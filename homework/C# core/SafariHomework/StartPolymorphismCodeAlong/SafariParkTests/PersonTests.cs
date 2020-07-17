
using NUnit.Framework;
using ClassesApp;

namespace ClassesTests
{
    public class PersonTests
    {
        [TestCase("Cathy", "French", "Cathy French")]
        [TestCase("", "", " ")]
        public void GetFullNameTest(string fName, string lName, string expected)
        {
            var subject = new Person(fName, lName);
            var result = subject.GetFullName();
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void AgeTest()
        {
            var subject = new Person("A", "B");
            subject.Age = 35;
            Assert.AreEqual(35, subject.Age);
        }
    }
}