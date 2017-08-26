using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArrayPrinter.Tests
{
    [TestClass]
    public class ArrayPrinterTests
    {
        [TestMethod]
        public void NoElementsTest()
        {
            int[,] arr=new int[0,0];

            string result = SpiralOrder.Print(arr);

            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void OneElementTest()
        {
            int[,] arr = new int[1, 1];
            arr[0, 0] = 4;

            string result = SpiralOrder.Print(arr);

            Assert.AreEqual("4", result);
        }

        [TestMethod]
        public void OneRowTest()
        {
            int[,] arr = new int[3, 1];
            arr[0, 0] = 4;
            arr[1, 0] = 7;
            arr[2, 0] = 2;

            string result = SpiralOrder.Print(arr);

            Assert.AreEqual("4 7 2", result);
        }

        [TestMethod]
        public void OneColTest()
        {
            int[,] arr = new int[1, 3];
            arr[0, 0] = 4;
            arr[0, 1] = 7;
            arr[0, 2] = 2;

            string result = SpiralOrder.Print(arr);

            Assert.AreEqual("4 7 2", result);
        }

        [TestMethod]
        public void MultRowAndColumnTest()
        {
            int[,] arr = new int[4, 5];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = 10 * i + j;
                    Console.Write(arr[i, j] + "\t");
                }
            }

            string result = SpiralOrder.Print(arr);

            Assert.AreEqual("0 10 20 30 31 32 33 34 24 14 4 3 2 1 11 21 22 23 13 12", result);
        }
    }
}
