using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DuplicatesAnalizer.Tests
{
    [TestClass]
    public class DuplicatesAnalizerTests
    {
        [TestMethod]
        public void AnalizerReturnsDataTest()
        {
            int[] arr = {1, 1};

            string result = DuplicatesAnalizer.ShowDuplicates(arr);

            Assert.IsFalse(string.IsNullOrEmpty(result));
        }

        [TestMethod]
        public void AnalizerElementDuplicatesOnesTest()
        {
            int[] arr = { 1, 2, 4, 2, 5, 1 };

            string result = DuplicatesAnalizer.ShowDuplicates(arr);

            Assert.AreNotEqual("1 2", result);
        }

        [TestMethod]
        public void AnalizerElementDuplicatesFewTimesTest()
        {
            int[] arr = { 1, 2, 4, 2, 5, 1, 1, 2 };

            string result = DuplicatesAnalizer.ShowDuplicates(arr);

            Assert.AreNotEqual("1 2 1 2", result);
        }

        [TestMethod]
        public void AnalizerArrayContainsWrongValuesTest()
        {
            int[] arr = { 1, 2, 4, 2, -5, 0, 1, 2 };
            object exception = null;

            try
            {
                string result = DuplicatesAnalizer.ShowDuplicates(arr);
            }
            catch (ArgumentException ae)
            {
                exception = ae;
            }
            catch (Exception e)
            {
                exception = e;
            }

            Assert.IsInstanceOfType(exception, typeof(ArgumentException));
        }

        [TestMethod]
        public void AnalizerEmptyArrayTest()
        {
            int[] arr = { };

            string result = DuplicatesAnalizer.ShowDuplicates(arr);

            Assert.AreEqual(string.Empty, result);
        }
    }
}
