using System;
using LinkedListTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkedList.Tests
{
    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        public void ListReturnsDataTest()
        {
            MyLinkedList myLinkedList = new MyLinkedList(3);

            Assert.IsNotNull(myLinkedList.ToString());
        }

        [TestMethod]
        public void OneElementReverseTest()
        {
            MyLinkedList myLinkedList = new MyLinkedList(3);

            Assert.AreEqual("3->", myLinkedList.ToString());
        }

        [TestMethod]
        public void ReverseListReturnsRorrectsDataTest()
        {
            MyLinkedList myLinkedList = new MyLinkedList(3,new MyLinkedList(1,new MyLinkedList(5,new MyLinkedList(4))));

            Assert.AreEqual("4->5->1->3->", myLinkedList.Reverse().ToString());
        }

        [TestMethod]
        public void ReverseEmplyListTest()
        {
            MyLinkedList myLinkedList = new MyLinkedList();

            Assert.AreEqual("0->", myLinkedList.Reverse().ToString());
        }
    }
}
