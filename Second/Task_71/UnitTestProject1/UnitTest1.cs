using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task_71;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ZeroTest()
        {
            int k = 0;

            int result = BitCounterFunc.F(k);

            Assert.AreEqual(1,result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NegativeTest()
        {
            int k = -2;

            BitCounterFunc.F(k);
        }

        [TestMethod]
        public void OneTest()
        {
            int k = 1;

            int result = BitCounterFunc.F(k);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void SimpleTest()
        {
            int k = 12;

            int result = BitCounterFunc.F(k);

            Assert.AreEqual(6, result);
        }
    }
}
