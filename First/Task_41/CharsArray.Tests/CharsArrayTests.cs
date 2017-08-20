using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharsArray.Tests
{
    [TestClass]
    public class CharsArrayTests
    {
        [TestMethod]
        public void ZeroTest()
        {
            int num = 0;

            char[] arr = CharsArray.GetCharsArrayFromNum(num);

            CollectionAssert.AreEqual(new[] {'0'}, arr);
        }

        [TestMethod]
        public void OneTest()
        {
            int num = 1;

            char[] arr = CharsArray.GetCharsArrayFromNum(num);

            CollectionAssert.AreEqual(new[] { '1' }, arr);
        }

        [TestMethod]
        public void PositiveNumberTest()
        {
            int num = 2534;

            char[] arr = CharsArray.GetCharsArrayFromNum(num);

            CollectionAssert.AreEqual(new[] { '2','5','3','4' }, arr);
        }

        [TestMethod]
        public void NegativeNumberTest()
        {
            int num = -2453;

            char[] arr = CharsArray.GetCharsArrayFromNum(num);

            CollectionAssert.AreEqual(new[] { '-', '2', '4', '5', '3' }, arr);
        }
    }
}
