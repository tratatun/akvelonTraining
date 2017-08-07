using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedListTools;

namespace LinkedList_starter
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList list = new MyLinkedList(2, new MyLinkedList(3, new MyLinkedList(5, new MyLinkedList(1, new MyLinkedList(5))))),
                list2;

            list2 = list.Reverse();



        }
    }
}
