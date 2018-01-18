using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycledSortedLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList(3);
            list.Insert(2);
            list.Insert(5);
            list.Insert(1);
            list.Insert(5);
            list.Insert(8);

            Console.WriteLine(list);
        }
    }
}
