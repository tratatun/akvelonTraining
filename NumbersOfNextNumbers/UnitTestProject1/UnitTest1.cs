using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;

namespace UnitTestProject1
{
    [TestClass]
    public class CalculateSubNumberTests
    {

        [TestMethod]
        public void EmptyArrayTest()
        {
            int[] arr = { };

            int[] result = CalculateSubNumber.Calculate(arr);

            CollectionAssert.AreEqual(result, new int[0]);
        }

        [TestMethod]
        public void OneElementTest()
        {
            int[] arr = { 3 };

            int[] result = CalculateSubNumber.Calculate(arr);

            CollectionAssert.AreEqual(result, new[] { 0 });
        }

        [TestMethod]
        public void SameElementsTest()
        {
            int[] arr = { 3, 3, 3, 3 };

            int[] result = CalculateSubNumber.Calculate(arr);

            CollectionAssert.AreEqual(result, new[] { 0, 0, 0, 0 });
        }

        [TestMethod]
        public void JustTest()
        {
            int[] arr = { 5, 3, 9, 8, 2, 6 };

            int[] result = CalculateSubNumber.Calculate(arr);

            CollectionAssert.AreEqual(result, new[] { 3, 3, 0, 0, 1, 0 });
        }


    }

}
