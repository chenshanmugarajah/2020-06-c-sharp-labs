using NUnit.Framework;
using lab_17_selection;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace lab_17_selection_tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Mark40AndOverPasses()
        {
            var result = PassFailClass.PassFail(41);
            Assert.AreEqual("Pass", result);
        }

        [Test]
        public void Mark39AndUnderFails()
        {
            var result = (PassFailClass.PassFail(39)).ToLower();
            Assert.AreEqual("fail", result);
        }

        [Test]
        public void GradePassWithDistinction()
        {
            var result = (PassFailClass.Grade(85)).ToLower();
            Assert.AreEqual("pass with distinction", result);
        }

        [Test]
        public void GradePassWithMerit()
        {
            var result = (PassFailClass.Grade(65)).ToLower();
            Assert.AreEqual("pass with merit", result);
        }

        [Test]
        public void GradePassWithPass()
        {
            var result = (PassFailClass.Grade(55)).ToLower();
            Assert.AreEqual("pass", result);
        }

        [Test]
        public void GradePassWithFail()
        {
            var result = (PassFailClass.Grade(35)).ToLower();
            Assert.AreEqual("fail", result);
        }

        [Test]
        public void GradeInvalid()
        {
            var result = (PassFailClass.Grade(-2)).ToLower();
            Assert.AreEqual("invalid input", result);
        }
    }
}