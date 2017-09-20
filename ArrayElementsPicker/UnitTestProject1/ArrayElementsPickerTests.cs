using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArrayElementsPickerTests
{
    [TestClass]
    public class ArrayElementsPickerTests
    {
        [TestMethod]
        public void EmptyListTest()
        {
            int[] arr = { };

             int [][] res = ArrayElementsPicker.ArrayElementsPicker.PickElemByRule(arr);

            CollectionAssert.AreEqual(res, new int[0][]);
        }

        [TestMethod]
        public void OneElemTest()
        {
            int[] arr = { 4 };

            int[][] res = ArrayElementsPicker.ArrayElementsPicker.PickElemByRule(arr);

            CollectionAssert.AreEqual(res, new int[0][]);
        }

        [TestMethod]
        public void RegularTest()
        {
            int[] arr = { 13, 5, 4 };

            int[][] res = ArrayElementsPicker.ArrayElementsPicker.PickElemByRule(arr);

            int[][] t = new[] {new[] {5, 4}};
            for (int i =0;i<res.Length;i++)
            {
                CollectionAssert.AreEquivalent(t[i], res[i]);

            }
        }

        [TestMethod]
        public void MultipleSameTest()
        {
            int[] arr = {1, 1, 1, 1, 1, 1};

            int[][] res = ArrayElementsPicker.ArrayElementsPicker.PickElemByRule(arr);

            int[][] t = new[]
            {
                new int[] {1, 1},
                new int[] {1, 1},
                new int[] {1, 1},
                new int[] {1, 1},
                new int[] {1, 1},
                new int[] {1, 1},
                new int[] {1, 1},
                new int[] {1, 1},
                new int[] {1, 1},
                new int[] {1, 1},
                new int[] {1, 1},
                new int[] {1, 1},
                new int[] {1, 1},
                new int[] {1, 1},
                new int[] {1, 1},
                new int[] {1, 1},
                
            };
            for (int i = 0; i < res.Length; i++)
            {
                CollectionAssert.AreEquivalent(t[i], res[i]);

            }
        }
    }
}
