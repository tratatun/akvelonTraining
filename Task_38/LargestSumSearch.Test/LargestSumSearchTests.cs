using System;
using System.Text;
using System.Collections.Generic;
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
        public void CorrectArrayTest()
        {
            int[] arr = { -2, -3, -4, 1, -2, -1, -5, -3 };

            int[] result = Task_38.LargestSumSearch.FindLargestSum(arr);

            CollectionAssert.AreEqual(new []{ 4, -1, -2, 1, 5 }, result);

        }
    }
}
