using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedListTools;

namespace LinkedListTools_starter
{
    class Program
    {
        static void Main(string[] args)
        {
            //create list 3-4-1-0-6-2-5
            MyLinkedList list = new MyLinkedList(3, new MyLinkedList(4, new MyLinkedList(1, new MyLinkedList(0, new MyLinkedList(6, new MyLinkedList(2, new MyLinkedList(5)))))));

            Console.WriteLine(list);

            //add at index
            list.AddAtIndex(new MyLinkedList(99), 3);

            Console.WriteLine(list);

            //add element in the tail
            list.AddLast(new MyLinkedList(12));

            Console.WriteLine(list);
            MyLinkedList.DeleteElement(ref list, 5);
            //delete enement and showing deleted
            Console.WriteLine(list);

            Console.WriteLine(list);

            Console.ReadKey();
        }
    }
}
