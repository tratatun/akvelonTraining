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
            SortedLinkedList list = new SortedLinkedList(3);

            list.AddNode(4);
            list.AddNode(2);
            list.AddNode(5);
            list.AddNode(-1);
            list.AddNode(0);
            list.AddNode(7);
            list.AddNode(2);
            list.AddNode(6);

            Console.WriteLine(list.ToString());

            Console.ReadKey();
        }
    }
}
