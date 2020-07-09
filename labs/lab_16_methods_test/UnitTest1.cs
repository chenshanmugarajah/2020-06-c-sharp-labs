using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using lab_15_unit_testings;

namespace lab_16_methods_test
{
    public class Tests
    {
        private int _result;
        private int _sum;

        [SetUp]
        public void Setup()
        {

        }

        [TestCase(10, 2, 4, 80)]
        [TestCase(5, 2, 2, 20)]
        [TestCase(0, 2, 4, 0)]
        public void ProductIsCorrect(int a, int b, int c, int expected)
        {
            //var actualResult = Calc.TripleCalc(10, 2, 4, out int sum);
            var actual = Calc.TripleCalc(a, b, c, out int sum);
            Assert.AreEqual(expected, actual);
        }

        //[Test]
        //public void SumIsCorrect()
        //{
        //    Assert.AreEqual(16, _sum);
        //}
    }
}