using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsArrayEmptyTest()
        {
            int[] arr = new int[0];
            int sum = 12;

            int counter = PairTools.PairCounter(arr, sum);

            Assert.AreEqual(-1, counter);

        }

        [TestMethod]
        public void CorrectArrayTest()
        {
            int[] arr = { -2, -1, 5, 6, 8, 10 };
            int sum = 7;

            int counter = PairTools.PairCounter(arr, sum);

            Assert.AreEqual(9, counter);

        }

        [TestMethod]
        public void OnlyOnePairTest()
        {
            int[] arr = { -2, -1, 5, 6, 8, 10 };
            int sum = 18;

            int counter = PairTools.PairCounter(arr, sum);

            Assert.AreEqual(1, counter);

        }

        [TestMethod]
        public void AnyPairTest()
        {
            int[] arr = { -2, -1, 5, 6, 8, 10 };
            int sum = 19;

            int counter = PairTools.PairCounter(arr, sum);

            Assert.AreEqual(0, counter);
        }
    }
}
