using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DuplicatesAnalizer.Tests
{
    [TestClass]
    public class DuplicatesAnalizerTests
    {
        [TestMethod]
        public void OnlyTwoDublicatesTest()
        {
            int[] arr = {1, 1};

            int[] result = DuplicatesAnalizer.ShowDuplicates(arr);

            CollectionAssert.AreEquivalent(result, new[] {1, 0});
        }

        [TestMethod]
        public void AnalizerElementTwoDuplicatesTest()
        {
            int[] arr = { 1, 2, 4, 2, 5, 1 };

            int[] result = DuplicatesAnalizer.ShowDuplicates(arr);

            CollectionAssert.AreEquivalent(result, new[] { 1, 0, 0, 2, -5, -1 });
        }

        [TestMethod]
        public void AnalizerElementDuplicatesFewTimesTest()
        {
            int[] arr = { 6, 4, 4, 3, 2, 2, 5, 1, 3 };

            int[] result = DuplicatesAnalizer.ShowDuplicates(arr);

            CollectionAssert.AreEquivalent(result, new[] { 5, -2, 0, 0, 0, -2, -6, 1, 3 });
        }

        [TestMethod]
        public void AllTheSameElementsArrayTest()
        {
            int[] arr = {1, 1, 1, 1, 1, 1, 1};

            int[] result = DuplicatesAnalizer.ShowDuplicates(arr);

            CollectionAssert.AreEquivalent(result, new[] { 1, 0, 1, 1, 1, 1, 1 });
        }

        [TestMethod]
        public void FewArrayTest()
        {
            int[] arr = { 1, 1, 2, 2, 3, 3, 1 };

            int[] result = DuplicatesAnalizer.ShowDuplicates(arr);

            CollectionAssert.AreEquivalent(result, new[] { 1, 0, 0, 0, 2, 3, 1 });
        }
    }
}
