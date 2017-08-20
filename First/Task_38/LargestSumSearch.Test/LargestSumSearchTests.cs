using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LargestSumSearch.Test
{
    /// <summary>
    /// Summary description for LargestSumSearchTests
    /// </summary>
    [TestClass]
    public class LargestSumSearchTests
    {
        [TestMethod]
        public void ArrayIsNotEmptyTest()
        {
            int[] arr = { -2, -3, -4, 1, 2, -1, -5, -3 };

            int[] result = new LargestSumSearch(arr).FindLargestSum();

            Assert.IsTrue(result.Length > 0);
        }

        [TestMethod]
        public void ArrayIsCorrectTest()
        {
            int[] arr = { -1, 4, -2, 5, -5, 2, -20, 6 };

            int[] result = new LargestSumSearch(arr).FindLargestSum();

            CollectionAssert.AreEqual(new[] { 4, -2, 5 }, result);
        }

        [TestMethod]
        public void ArrayAllNegativeTest()
        {
            int[] arr = { -11, -4, -2, -5, -5, -2, -20, -6 };

            int[] result = new LargestSumSearch(arr).FindLargestSum();

            CollectionAssert.AreEqual(new[] { -2 }, result);
        }

        [TestMethod]
        public void ArrayAllPositiveTest()
        {
            int[] arr = { 11, 4, 2, 5, 5, 2, 20, 6 };

            int[] result = new LargestSumSearch(arr).FindLargestSum();

            CollectionAssert.AreEqual(new[] { 11, 4, 2, 5, 5, 2, 20, 6 }, result);
        }

        [TestMethod]
        public void ArrayIsEmptyTest()
        {
            int[] arr = new int[0];

            int[] result = new LargestSumSearch(arr).FindLargestSum();

            CollectionAssert.AreEqual(new int[0], result);
        }

        [TestMethod]
        public void ArrayOneZeroElementTest()
        {
            int[] arr = {0};

            int[] result = new LargestSumSearch(arr).FindLargestSum();

            CollectionAssert.AreEqual(new []{0}, result);
        }

        [TestMethod]
        public void ArrayFirstMaxElementTest()
        {
            int[] arr = { 4,-2,-1,-1 };

            int[] result = new LargestSumSearch(arr).FindLargestSum();

            CollectionAssert.AreEqual(new[] { 4 }, result);
        }

        [TestMethod]
        public void TwoLargestSumTest()
        {
            int[] arr = {1, -2, 2, 1, -4, 1, 1, 1 - 1};

            int[] result = new LargestSumSearch(arr).FindLargestSum();

            CollectionAssert.AreEqual(new[] { 2, 1 }, result);
        }
    }
}
