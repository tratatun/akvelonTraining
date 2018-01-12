using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DuplicatesAnalizerExtraSpace.Tests
{
    [TestClass]
    public class DuplicatesAnalizerExtraSpaceTests
    {
        [TestMethod]
        public void OnlyTwoDublicatesTest()
        {
            int[] arr = { 1 };

            int[] result = DuplicatesAnalizerExtraSpace.ShowDuplicates(arr);

            CollectionAssert.AreEquivalent(result, null);
        }

        [TestMethod]
        public void AnalizerElementTwoDuplicatesTest()
        {
            int[] arr = { 1, 2, 4, 2, 5, 1 };

            int[] result = DuplicatesAnalizerExtraSpace.ShowDuplicates(arr);

            CollectionAssert.AreEquivalent(result, new[] { 1, 2 });
        }

        [TestMethod]
        public void AnalizerElementDuplicatesFewTimesTest()
        {
            int[] arr = { 6, 4, 4, 3, 2, 2, 5, 1, 3 };

            int[] result = DuplicatesAnalizerExtraSpace.ShowDuplicates(arr);

            CollectionAssert.AreEquivalent(result, new[] {2, 3, 4});
        }

        [TestMethod]
        public void AllTheSameElementsArrayTest()
        {
            int[] arr = { 1, 1, 1, 1, 1, 1, 1 };

            int[] result = DuplicatesAnalizerExtraSpace.ShowDuplicates(arr);

            CollectionAssert.AreEquivalent(result, new[] { 1 });
        }

        [TestMethod]
        public void AscendingArrayTest()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 6 };

            int[] result = DuplicatesAnalizerExtraSpace.ShowDuplicates(arr);

            CollectionAssert.AreEquivalent(result, new[] { 6 });
        }

        [TestMethod]
        public void DescendingArrayTest()
        {
            int[] arr = {5, 4, 3, 2, 1, 1};

            int[] result = DuplicatesAnalizerExtraSpace.ShowDuplicates(arr);

            CollectionAssert.AreEquivalent(result, new[] { 1 });
        }
    }
}
