using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestWrongInputOverK()
        {
            int[] arr = new[] {3, 4, 2, 1};
            int K = 3;

            Assert.ThrowsException<Exception>(() => { SortingWithExtraSpace.SortingWithExtraSpace.Sort(arr, K); });

        }

        [TestMethod]
        public void TestWrongInputZero()
        {
            int[] arr = new[] { 3, 4, 2, 0 };
            int K = 5;

            Assert.ThrowsException<Exception>(() => { SortingWithExtraSpace.SortingWithExtraSpace.Sort(arr, K); });

        }

        [TestMethod]
        public void TestWrongInputZeroK()
        {
            int[] arr = new[] { 3, 2, 1 };
            int K = 0;

            

            Assert.ThrowsException<Exception>(() => { arr = SortingWithExtraSpace.SortingWithExtraSpace.Sort(arr, K); });

        }

        [TestMethod]
        public void TestCorrectInputKGreaterN()
        {
            int[] arr = new[] { 3, 4, 2, 1 };
            int K = 6;

            arr = SortingWithExtraSpace.SortingWithExtraSpace.Sort(arr, K);

            CollectionAssert.AreEquivalent(new int[] {1, 2, 3, 4}, arr);

        }


        [TestMethod]
        public void TestCorrectInputNGreaterK()
        {
            int[] arr = new[] { 3, 1, 2, 1, 3, 1 };
            int K = 3;

            arr = SortingWithExtraSpace.SortingWithExtraSpace.Sort(arr, K);

            CollectionAssert.AreEquivalent(new int[] { 1, 1, 1, 2, 3, 3 }, arr);

        }

        [TestMethod]
        public void TestCorrectInputNEqualsK()
        {
            int[] arr = new[] {3, 1, 2, 4};
            int K = 4;

            arr = SortingWithExtraSpace.SortingWithExtraSpace.Sort(arr, K);

            CollectionAssert.AreEquivalent(new int[] {1, 2, 3, 4}, arr);

        }

        [TestMethod]
        public void TestCorrectInputOne()
        {
            int[] arr = new[] { 3 };
            int K = 3;

            arr = SortingWithExtraSpace.SortingWithExtraSpace.Sort(arr, K);

            CollectionAssert.AreEquivalent(new int[] { 3 }, arr);

        }

    }
}
