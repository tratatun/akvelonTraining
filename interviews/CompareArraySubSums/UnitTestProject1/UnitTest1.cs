using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CompareArraySubSums;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMiddleInStart()
        {
            int[] arr = {2, 3, 5, 6, -4};
            int mid = 2;

            bool res = Program.CheckArraySubSums(arr, mid);

            Assert.AreEqual(res, false);

        }

        [TestMethod]
        public void TestMiddleInEnd()
        {
            int[] arr = {2, 3, 5, 6, -4};
            int mid = -4;

            bool res = Program.CheckArraySubSums(arr, mid);

            Assert.AreEqual(res, false);

        }

        [TestMethod]
        public void TestMultipleMiddles()
        {
            int[] arr = {2, 3, 5, 3, -4};
            int mid = 3;
            string err = string.Empty;

            try
            {
                bool res = Program.CheckArraySubSums(arr, mid);
            }
            catch (Exception e)
            {
                err = e.Message;
            }

            Assert.AreEqual(err, "Wrong Input: multiple middles");

        }


        [TestMethod]
        public void TestEmpty()
        {
            int[] arr = { };
            string err = string.Empty;

            int mid = 3;

            try

            {
                bool res = Program.CheckArraySubSums(arr, mid);
            }
            catch (Exception e)
            {
                err = e.Message;
            }

            Assert.AreEqual(err, "Wrong Input: empty array");

        }

        [TestMethod]
        public void TestIncorrect()
        {
            int[] arr = {2, 3, 5, 6, -4};
            int mid = 5;

            bool res = Program.CheckArraySubSums(arr, mid);

            Assert.AreEqual(res, false);

        }

        [TestMethod]
        public void TestCorrect()
        {
            int[] arr = {2, 3, 5, 4, -4};
            int mid = 5;

            bool res = Program.CheckArraySubSums(arr, mid);

            Assert.AreEqual(res, true);

        }
    }
}
