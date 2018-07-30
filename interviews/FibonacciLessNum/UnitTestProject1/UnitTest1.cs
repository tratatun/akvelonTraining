using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FibonacciLessNum;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckFiboTest()
        {
            //assign 
            int n = 7;

            //act
            double currVal = (Math.Pow((1 + Math.Sqrt(5)) / 2, n) - Math.Pow((1 - Math.Sqrt(5)) / 2, n)) / Math.Sqrt(5);
            long[] arr = Program.GetFibonacciArr(n);

            //assert
            Assert.AreEqual((int)currVal, arr[n]);

        }

        [TestMethod]
        public void ZeroTest()
        {
            //assign 
            int n = 0;

            //act
            double currVal = (Math.Pow((1 + Math.Sqrt(5)) / 2, n) - Math.Pow((1 - Math.Sqrt(5)) / 2, n)) / Math.Sqrt(5);
            long[] arr = Program.GetFibonacciArr(n);

            //assert
            Assert.AreEqual((int)currVal, arr[n]);

        }

        [TestMethod]
        public void MaxIntTest()
        {
            //assign 
            int n = 46;

            //act
            double currVal = (Math.Pow((1 + Math.Sqrt(5)) / 2, n) - Math.Pow((1 - Math.Sqrt(5)) / 2, n)) / Math.Sqrt(5);
            long[] arr = Program.GetFibonacciArr(n);

            //assert
            Assert.AreEqual((int)currVal, arr[n]);

        }
    }
}
