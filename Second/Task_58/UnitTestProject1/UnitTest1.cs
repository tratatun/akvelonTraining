using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestInputZero()
        {
            int[] arr = {1, 0, 3, 4, 1};
            string err1 = string.Empty;
            string err2 = string.Empty;
            try
            {

                bool res1 = Program.CheckForDuplicates_ByExtraSpace(arr);

            }
            catch (Exception e)
            {
                err1 = e.Message;
            }

            try
            {

                bool res2 = Program.CheckForDuplicates_ByModifyArray(arr);

            }
            catch (Exception e)
            {
                err2 = e.Message;
            }

            Assert.AreEqual(err1, "Wrong Input");
            Assert.AreEqual(err2, "Wrong Input");
        }

        [TestMethod]
        public void TestInputN()
        {
            int[] arr = { 1, 2, 6, 4, 1 };
            string err1 = string.Empty;
            string err2 = string.Empty;
            try
            {

                bool res1 = Program.CheckForDuplicates_ByExtraSpace(arr);

            }
            catch (Exception e)
            {
                err1 = e.Message;
            }

            try
            {

                bool res2 = Program.CheckForDuplicates_ByModifyArray(arr);

            }
            catch (Exception e)
            {
                err2 = e.Message;
            }

            Assert.AreEqual(err1, "Wrong Input");
            Assert.AreEqual(err2, "Wrong Input");
        }

        [TestMethod]
        public void TestInputDuplicates()
        {
            int[] arr = {1, 2, 3, 4, 1};

            bool res1 = Program.CheckForDuplicates_ByExtraSpace(arr);

            bool res2 = Program.CheckForDuplicates_ByModifyArray(arr);

            Assert.AreEqual(res1, true);
            Assert.AreEqual(res2, true);
        }

        [TestMethod]
        public void TestInputNoDuplicates()
        {
            int[] arr = { 1, 2, 5, 4, 3 };

            bool res1 = Program.CheckForDuplicates_ByExtraSpace(arr);

            bool res2 = Program.CheckForDuplicates_ByModifyArray(arr);

            Assert.AreEqual(res1, false);
            Assert.AreEqual(res2, false);
        }

        [TestMethod]
        public void TestOneElem()
        {
            int[] arr = { 1 };

            bool res1 = Program.CheckForDuplicates_ByExtraSpace(arr);

            bool res2 = Program.CheckForDuplicates_ByModifyArray(arr);

            Assert.AreEqual(res1, false);
            Assert.AreEqual(res2, false);
        }

        [TestMethod]
        public void TestAllDuplicates()
        {
            int[] arr = {2, 2, 2, 2, 2};

            bool res1 = Program.CheckForDuplicates_ByExtraSpace(arr);

            bool res2 = Program.CheckForDuplicates_ByModifyArray(arr);

            Assert.AreEqual(res1, true);
            Assert.AreEqual(res2, true);
        }
    }
}
