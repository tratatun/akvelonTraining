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

            MyLinkedList.DeleteElement(ref list, 3);

            Assert.AreEqual("3->4->2->1->2->5->", list.ToString());
        }

        [TestMethod]
        public void DeleteNodeAtHeadIndexInListTest()
        {
            MyLinkedList list = new MyLinkedList(3, new MyLinkedList(4, new MyLinkedList(2, new MyLinkedList(7, new MyLinkedList(1, new MyLinkedList(2, new MyLinkedList(5)))))));

            MyLinkedList.DeleteElement(ref list, 0);

            Assert.AreEqual("4->2->7->1->2->5->", list.ToString());
        }
        [TestMethod]
        public void DeleteNodeByValueFirstTest()
        {
            MyLinkedList list = new MyLinkedList(3, new MyLinkedList(4, new MyLinkedList(2, new MyLinkedList(7, new MyLinkedList(1, new MyLinkedList(2, new MyLinkedList(5)))))));

            MyLinkedList.DeleteByValue(ref list, 3);
            string listContent = list.ToString();

            Assert.AreEqual("4->2->7->1->2->5->", listContent);
        }

        [TestMethod]
        public void DeleteNodeByValueTest()
        {
            MyLinkedList list = new MyLinkedList(3, new MyLinkedList(4, new MyLinkedList(2, new MyLinkedList(7, new MyLinkedList(1, new MyLinkedList(2, new MyLinkedList(5)))))));

            MyLinkedList.DeleteByValue(ref list, 7);
            string listContent = list.ToString();

            Assert.AreEqual("3->4->2->1->2->5->", listContent);
        }
        [TestMethod]
        public void DeleteAllNodesByValueTest()
        {
            MyLinkedList list = new MyLinkedList(3, new MyLinkedList(4, new MyLinkedList(2, new MyLinkedList(7, new MyLinkedList(1, new MyLinkedList(2, new MyLinkedList(5)))))));

            MyLinkedList.DeleteByValue(ref list, 7);
            MyLinkedList.DeleteByValue(ref list, 4);
            MyLinkedList.DeleteByValue(ref list, 3);
            MyLinkedList.DeleteByValue(ref list, 2);
            MyLinkedList.DeleteByValue(ref list, 1);
            MyLinkedList.DeleteByValue(ref list, 5);
            MyLinkedList.DeleteByValue(ref list, 2);

            Assert.IsNull(list);
        }
    }
}
