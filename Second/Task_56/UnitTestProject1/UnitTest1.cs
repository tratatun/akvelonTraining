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
                ListArray.CreateListArray(arr);
            }
            catch (Exception e)
            {
                ex = e.Message;
            }

            Assert.AreEqual(ex, "List is empty!");

        }

        [TestMethod]
        public void TestNullArray()
        {
            int[] arr = null;
            string ex = String.Empty;
            try
            {
                ListArray.CreateListArray(arr);
            }
            catch (Exception e)
            {
                ex = e.Message;
            }

            Assert.AreEqual(ex, "List is empty!");

        }

        [TestMethod]
        public void TestNotSortedArray()
        {
            int[] arr = {1, 1, 3, 3, 3, 2, 2};
            string ex = String.Empty;
            try
            {
                ListArray.CreateListArray(arr);
            }
            catch (Exception e)
            {
                ex = e.Message;
            }

            Assert.AreEqual(ex, "List is not sorted!");

        }

        [TestMethod]
        public void TestNoDuplicatesArray()
        {
            int[] arr = {1, 2, 3, 4};

            ListArray result = ListArray.CreateListArray(arr);
            result.RemoveDuplicates();

            Assert.AreEqual(result.ToString(), "1->2->3->4->");
        }

        [TestMethod]
        public void TestDuplicatesArray()
        {
            int[] arr = {1, 1, 2, 3, 3, 3, 3, 4, 4, 4, 5, 5};

            ListArray result = ListArray.CreateListArray(arr);
            result.RemoveDuplicates();

            Assert.AreEqual(result.ToString(), "1->2->3->4->5->");
        }

        [TestMethod]
        public void TestSingleElement()
        {
            int[] arr = { 3 };

            ListArray result = ListArray.CreateListArray(arr);
            result.RemoveDuplicates();

            Assert.AreEqual(result.ToString(), "3->");
        }

        [TestMethod]
        public void TestZeroElement()
        {
            int[] arr = { 0 };

            ListArray result = ListArray.CreateListArray(arr);
            result.RemoveDuplicates();

            Assert.AreEqual(result.ToString(), "0->");
        }


        [TestMethod]
        public void TestIntMaxMinElement()
        {
            int[] arr = { int.MinValue, int.MinValue, 1, 2, 2, int.MaxValue, int.MaxValue };

            ListArray result = ListArray.CreateListArray(arr);
            result.RemoveDuplicates();

            Assert.AreEqual(result.ToString(), int.MinValue + "->1->2->" + int.MaxValue + "->");
        }

    }
}
