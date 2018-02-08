using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task_67;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestOddNum()
        {
            MyList list = new MyList(1);
            list.Next = new MyList(2);
            list.Next.Next = new MyList(3);
            list.Next.Next.Next = new MyList(4);
            list.Next.Next.Next.Next = new MyList(5);

            int mid = list.GetMiddle();

            Assert.AreEqual(3, mid);
        }

        [TestMethod]
        public void TestEvenNum()
        {
            MyList list = new MyList(1);
            list.Next = new MyList(2);
            list.Next.Next = new MyList(3);
            list.Next.Next.Next = new MyList(4);
            list.Next.Next.Next.Next = new MyList(5);
            list.Next.Next.Next.Next.Next = new MyList(6);
            list.Next.Next.Next.Next.Next.Next = new MyList(7);
            list.Next.Next.Next.Next.Next.Next.Next = new MyList(8);

            int mid = list.GetMiddle();

            Assert.AreEqual(4, mid);
        }

        [TestMethod]
        public void TestOneNum()
        {
            MyList list = new MyList(1);

            int mid = list.GetMiddle();

            Assert.AreEqual(1, mid);
        }
    }
}
