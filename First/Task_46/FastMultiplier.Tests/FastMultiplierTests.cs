using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FastMultiplier.Tests
{
    [TestClass]
    public class FastMultiplierTests
    {
        [DataTestMethod]
        [DataRow(0, 0)]
        [DataRow(3, 21)]
        [DataRow(1, 7)]
        [DataRow(6, 42)]
        [DataRow(11, 77)]
        public void MultiplyTest(int before, int expected)
        {
            int result;

            result = FastMultiplier.FastMultiplierTo7(before);

            Assert.AreEqual(expected, result);
        }


    }
}
