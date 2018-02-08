using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_67
{
    class Program
    {
        /*
         * 67. Given a singly linked list, find the middle of the list.
         */
        static void Main(string[] args)
        {
            MyList list;
            string[] strArr = Console.ReadLine().Split(' ');
            list = new MyList(int.Parse(strArr[0]));
            MyList next = list;
            for (int i = 1; i < strArr.Length; i++)
            {
                next.Next= new MyList(int.Parse(strArr[i]));
                next = next.Next;
            }

            Console.WriteLine(list.GetMiddle());

        }
        
    }
    public class MyList
    {
        public int Data;
        public MyList Next;

        public MyList(int data)
        {
            Data = data;
        }

        private int GetLength(int count = 0)
        {
            if (Next != null)
            {
                return Next.GetLength(++count);
            }
            return count;
        }

        public int GetMiddle(int count = 0, int length = 0)
        {
            length = length == 0 ? GetLength() : length;
            if (count == length / 2)
            {
                return Data;
            }

            return Next.GetMiddle(++count, length);
        }

        public override string ToString()
        {
            return Data + "->" + Next;
        }
    }
}
