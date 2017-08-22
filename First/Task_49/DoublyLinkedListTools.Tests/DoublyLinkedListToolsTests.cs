using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DoublyLinkedListTools.Tests
{
    [TestClass]
    public class DoublyLinkedListToolsTests
    {
        [TestMethod]
        public void ListCreatedTest()
        {
            DoublyLinkedList dList = new DoublyLinkedList(5, new DoublyLinkedList(2));

            Assert.IsNotNull(dList.Next);
        }

        [TestMethod]
        public void DeleteAtIndexTest()
        {
            DoublyLinkedList dList = new DoublyLinkedList(5);

            DoublyLinkedList pointer = dList;
            for (int i = 0; i < 6; i++)
            {
                pointer.Next = new DoublyLinkedList(i * 2);
                pointer = pointer.Next;
            }

            DoublyLinkedListTools.DeleteElementNextAt(dList, 3);

            Assert.AreEqual("5<->0<->2<->6<->8<->10", dList.ToString());
        }

        [TestMethod]
        public void DeleteWithDataTest()
        {
            DoublyLinkedList dList = new DoublyLinkedList(5);

            DoublyLinkedList pointer = dList;
            for (int i = 0; i < 6; i++)
            {
                pointer.Next = new DoublyLinkedList(i * 2);
                pointer = pointer.Next;
            }

            dList = DoublyLinkedListTools.DeleteElementWithData(dList, 2);

            Assert.AreEqual("5<->0<->4<->6<->8<->10", dList.ToString());
        }

        [TestMethod]
        public void DeleteDataInTailTest()
        {
            DoublyLinkedList dList = new DoublyLinkedList(5);

            DoublyLinkedList pointer = dList;
            for (int i = 0; i < 6; i++)
            {
                pointer.Next = new DoublyLinkedList(i * 2);
                pointer = pointer.Next;
            }

            dList = DoublyLinkedListTools.DeleteElementWithData(dList, 10);

            Assert.AreEqual("5<->0<->2<->4<->6<->8", dList.ToString());
        }
        [TestMethod]
        public void DeleteDataInHeadTest()
        {
            DoublyLinkedList dList = new DoublyLinkedList(5);

            DoublyLinkedList pointer = dList;
            for (int i = 0; i < 6; i++)
            {
                pointer.Next = new DoublyLinkedList(i * 2);
                pointer = pointer.Next;
            }

            dList = DoublyLinkedListTools.DeleteElementWithData(dList, 5);

            Assert.AreEqual("0<->2<->4<->6<->8<->10", dList.ToString());
        }

        [TestMethod]
        public void DeleteElementInListWithOnlyOneElementTest()
        {
            DoublyLinkedList dList = new DoublyLinkedList(5);

            dList = DoublyLinkedListTools.DeleteElementWithData(dList, 5);

            Assert.IsNull(dList);
        }

        [TestMethod]
        public void DeleteUnexistingIndexElementTest()
        {
            DoublyLinkedList dList = new DoublyLinkedList(5);

            DoublyLinkedList pointer = dList;
            for (int i = 0; i < 3; i++)
            {
                pointer.Next = new DoublyLinkedList(i * 2);
                pointer = pointer.Next;
            }
            dList = DoublyLinkedListTools.DeleteElementNextAt(dList, 5);

            Assert.AreEqual("5<->0<->2<->4", dList.ToString());
        }

        [TestMethod]
        public void DeleteUnexistingDataElementTest()
        {
            DoublyLinkedList dList = new DoublyLinkedList(5);

            DoublyLinkedList pointer = dList;
            for (int i = 0; i < 3; i++)
            {
                pointer.Next = new DoublyLinkedList(i * 2);
                pointer = pointer.Next;
            }
            dList = DoublyLinkedListTools.DeleteElementWithData(dList, 33);

            Assert.AreEqual("5<->0<->2<->4", dList.ToString());
        }
    }
}
