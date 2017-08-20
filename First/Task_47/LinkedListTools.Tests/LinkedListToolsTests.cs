using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkedListTools.Tests
{
    [TestClass]
    public class LinkedListToolsTests
    {
        [TestMethod]
        public void ListIsNotEmptyTest()
        {
            MyLinkedList list = new MyLinkedList(3, new MyLinkedList(4));

            string listContent = list.ToString();

            Assert.IsNotNull(listContent);
        }

        [TestMethod]
        public void ListIsCorrectTest()
        {
            MyLinkedList list = new MyLinkedList(3, new MyLinkedList(4));

            string listContent = list.ToString();

            Assert.AreEqual("3->4->", listContent);
        }

        [TestMethod]
        public void AddNodeInTheEndOfListTest()
        {
            MyLinkedList list = new MyLinkedList(3, new MyLinkedList(4, new MyLinkedList(2)));

            list.AddLast(new MyLinkedList(21));
            string listContent = list.ToString();

            Assert.AreEqual("3->4->2->21->", listContent);
        }

        [TestMethod]
        public void AddNodeAtIndexInListTest()
        {
            MyLinkedList list = new MyLinkedList(3, new MyLinkedList(4, new MyLinkedList(2, new MyLinkedList(7, new MyLinkedList(1, new MyLinkedList(2, new MyLinkedList(5)))))));

            list.AddAtIndex(new MyLinkedList(21),3);
            string listContent = list.ToString();

            Assert.AreEqual("3->4->2->21->7->1->2->5->", listContent);
        }

        [TestMethod]
        public void DeleteNodeAtIndexInListTest()
        {
            MyLinkedList list = new MyLinkedList(3, new MyLinkedList(4, new MyLinkedList(2, new MyLinkedList(7, new MyLinkedList(1, new MyLinkedList(2, new MyLinkedList(5)))))));

            list.DeleteElement(3);
            string listContent = list.ToString();

            Assert.AreEqual("3->4->2->1->2->5->", listContent);
        }

        [TestMethod]
        public void DeleteNodeAtIndexInListShowsDeletedNodeTest()
        {
            MyLinkedList list = new MyLinkedList(3, new MyLinkedList(4, new MyLinkedList(2, new MyLinkedList(7, new MyLinkedList(1, new MyLinkedList(2, new MyLinkedList(5)))))));

            MyLinkedList deleted = list.DeleteElement(3);
            
            Assert.AreEqual("7->", deleted.ToString());
        }
    }
}
