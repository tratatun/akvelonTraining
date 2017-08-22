using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoublyLinkedListTools;

namespace DoublyLinkedListTools_starter
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList doublyLinkedList = new DoublyLinkedList(2);
            DoublyLinkedList pointer = doublyLinkedList;
            for (int i = 0; i < 14; i++)
            {
                pointer.Next = new DoublyLinkedList(3 + i);
                pointer = pointer.Next;
            }

            doublyLinkedList = DoublyLinkedListTools.DoublyLinkedListTools.DeleteElementWithData(doublyLinkedList, 2);
            doublyLinkedList = DoublyLinkedListTools.DoublyLinkedListTools.DeleteElementNextAt(doublyLinkedList, 3);
            Console.WriteLine(doublyLinkedList.ToString());
        }
    }
}
