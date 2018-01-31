using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_56
{
    class Program
    {
        /*
         * Write, efficient code for extracting unique elements from a sorted list of array. e.g. (1, 1, 3, 3, 3, 5, 5, 5, 9, 9, 9, 9) -> (1, 3, 5, 9).
         */
        static void Main(string[] args)
        {
            string[] arrStr = Console.ReadLine().Split(' ');
            int[] arr = new int[arrStr.Length];
            for (int i = 0; i < arrStr.Length; i++)
            {
                arr[i] = int.Parse(arrStr[i]);
            }
            ListArray listArr = ListArray.CreateListArray(arr);

            listArr.RemoveDuplicates();

            Console.WriteLine(listArr.ToString());
        }
    }

    public class ListArray
    {
        public int Data;

        public ListArray Next;

        public void RemoveDuplicates()
        {
            if (Next != null)
            {
                if (Next.Data == Data)
                {
                    Next = Next.Next;
                    RemoveDuplicates();
                }
                else
                {
                    Next.RemoveDuplicates();
                }
            }
        }

        public static ListArray CreateListArray(int[] arr)
        {
            if (arr == null || arr.Length==0)
            {
                throw new ArgumentException("List is empty!");
            }

            ListArray listArray = null, currListArray = null;
            for (int i = 0; i < arr.Length; i++)
            {
                if (currListArray == null)
                {
                    currListArray = new ListArray {Data = arr[i]};
                    listArray = currListArray;
                }
                else
                {
                    int current = arr[i];
                    if (currListArray.Data > current)
                    {
                        throw new ArgumentException("List is not sorted!");
                    }

                    currListArray.Next = new ListArray {Data = current};
                    currListArray = currListArray.Next;

                }
            }

            return listArray;
        }

        public override string ToString()
        {
            return Data + "->" + Next;
        }
    }
}
