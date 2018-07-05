using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NullTest()
        {
            //arrange
            int[] arr = null;
            //act
            string result = GFG.StockBuySell(arr);

            //assert
            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void EmptyTest()
        {
            //arrange
            int[] arr = { };
            //act
            string result = GFG.StockBuySell(arr);

            //assert
            Assert.AreEqual("", result);
        }
        [TestMethod]
        public void UsualTestCase()
        {
            //arrange
            int[] arr = { 100, 180, 260, 310, 40, 535, 695 };
            //act
            string result = GFG.StockBuySell(arr);

            //assert
            Assert.AreEqual("(0 3) (4 6)", result);
        }

        [TestMethod]
        public void AnotherTestCase()
        {
            //arrange
            int[] arr = { 23, 13, 25, 29, 33, 19, 34, 45, 65, 67 };
            //act
            string result = GFG.StockBuySell(arr);

            //assert
            Assert.AreEqual("(1 4) (5 9)", result);
        }
        [TestMethod]
        public void AllEqualTest()
        {
            //arrange
            int[] arr = { 23, 23, 23, 23, 23 };
            //act
            string result = GFG.StockBuySell(arr);

            //assert
            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void AscSortedTest()
        {
            //arrange
            int[] arr = { 23, 24, 25, 27, 29 };
            //act
            string result = GFG.StockBuySell(arr);

            //assert
            Assert.AreEqual("(0 4)", result);
        }


        [TestMethod]
        public void DescSortedTest()
        {
            //arrange
            int[] arr = { 23, 22, 21, 20, 19 };
            //act
            string result = GFG.StockBuySell(arr);

            //assert
            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void OneElemTest()
        {
            //arrange
            int[] arr = { 23 };
            //act
            string result = GFG.StockBuySell(arr);

            //assert
            Assert.AreEqual("", result);
        }

    }
}
