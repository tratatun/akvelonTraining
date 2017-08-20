using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LooplessPow.Tests
{
    [TestClass]
    public class LooplessPowTests
    {
        [TestMethod]
        public void ZeroTest()
        {
            int pow = 0;

            bool isPow = LooplessPow.IsNumberPowerOfTwo(pow);

            Assert.AreEqual(false, isPow);
        }

        [TestMethod]
        public void NegativeTest()
        {
            int pow = -2;

            bool isPow = LooplessPow.IsNumberPowerOfTwo(pow);

            Assert.AreEqual(false, isPow);
        }

        [TestMethod]
        public void PowTwoTest()
        {
            int pow = 8;

            bool isPow = LooplessPow.IsNumberPowerOfTwo(pow);

            Assert.AreEqual(true, isPow);
        }

        [TestMethod]
        public void NotPowTwoTest()
        {
            int pow = 11;

            bool isPow = LooplessPow.IsNumberPowerOfTwo(pow);

            Assert.AreEqual(false, isPow);
        }
    }
}
