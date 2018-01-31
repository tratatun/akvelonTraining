using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task_56;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestEmptyArray()
        {
            int[] arr = new int [0];
            string ex = String.Empty;
            try
            {
                UniqueElementsInArray.GetUniques(arr);
            }
            catch (Exception e)
            {
                ex = e.Message;
            }

            Assert.AreEqual(ex, "Empty array");

        }

        [TestMethod]
        public void TestNullArray()
        {
            int[] arr = null;
            string ex = String.Empty;
            try
            {
                UniqueElementsInArray.GetUniques(arr);
            }
            catch (Exception e)
            {
                ex = e.Message;
            }

            Assert.AreEqual(ex, "Empty array");

        }

        [TestMethod]
        public void TestNotSortedArray()
        {
            int[] arr = {1, 1, 3, 3, 3, 2, 2};
            string ex = String.Empty;
            try
            {
                UniqueElementsInArray.GetUniques(arr);
            }
            catch (Exception e)
            {
                ex = e.Message;
            }

            Assert.AreEqual(ex, "Not sorted");

        }

        [TestMethod]
        public void TestNegativeElementArray()
        {
            int[] arr = { 1, 1, -3, 3, 3, 2, 2 };
            string ex = String.Empty;
            try
            {
                UniqueElementsInArray.GetUniques(arr);
            }
            catch (Exception e)
            {
                ex = e.Message;
            }

            Assert.AreEqual(ex, "Negative element");

        }

        [TestMethod]
        public void TestNoDuplicatesArray()
        {
            int[] arr = {1, 2, 3, 4};
            int[] result = {1, 2, 3, 4};

            result = UniqueElementsInArray.GetUniques(arr);

            CollectionAssert.AreEqual(result, new[] {1, 2, 3, 4});
        }

        [TestMethod]
        public void TestArray()
        {
            int[] arr = {1, 1, 2, 3, 3, 3, 3, 4, 4, 4, 5, 5};
            int[] result = { 1, 2, 3, 4, 5 };

            result = UniqueElementsInArray.GetUniques(arr);

            CollectionAssert.AreEqual(result, new[] { 1, 2, 3, 4, 5 });
        }

    }
}
