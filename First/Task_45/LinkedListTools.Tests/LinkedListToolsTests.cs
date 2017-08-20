using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkedListTools.Tests
{
    [TestClass]
    public class LinkedListToolsTests
    {
        [TestMethod]
        public void SortedListIsNotEmptyTest()
        {
            SortedLinkedList list = new SortedLinkedList(3);
            list.AddNode(2);
            list.AddNode(6);

            string ser = list.ToString();

            Assert.IsNotNull(ser);
        }

        [TestMethod]
        public void SortedListIsCorrectTest()
        {
            SortedLinkedList list = new SortedLinkedList(3);
            list.AddNode(2);
            list.AddNode(6);
            list.AddNode(-3);
            list.AddNode(3);
            list.AddNode(1);
            list.AddNode(5);

            string ser = list.ToString();

            Assert.AreEqual(ser, "-3->1->2->3->3->5->6->");
        }

        [TestMethod]
        public void SortedListIsEmptyTest()
        {
            SortedLinkedList list = new SortedLinkedList();

            string ser = list.ToString();

            Assert.AreEqual(ser, "");
        }

        [TestMethod]
        public void SortedListTheSameValuesTest()
        {
            SortedLinkedList list = new SortedLinkedList(3);
            list.AddNode(3);
            list.AddNode(3);

            string ser = list.ToString();

            Assert.AreEqual(ser, "3->3->3->");
        }
    }
}
