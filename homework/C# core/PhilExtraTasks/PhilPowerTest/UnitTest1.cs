using NUnit.Framework;
using PhilPowerTests;
using System;

namespace PhilPowerTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(2, 2, 2)]
        [TestCase(2, 5, 2)]
        public void multiplyPowersTest(double x, double y, int z)
        {
            double ans = x * y;
            for (int i=1; i<z; i++)
            {
                ans *= ans;
            }
            Assert.AreEqual(ans, Powers.RaiseToPower(x, y, z));
        }
    }
}