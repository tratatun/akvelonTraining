using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_62
{
    class Program
    {
        /*
         62. Write a program to remove duplicates from a sorted array.
         */
        static void Main(string[] args)
        {
            string[] arrStr = Console.ReadLine().Split(' ');
            int[] arr = new int[arrStr.Length];
            for (int i = 0; i < arrStr.Length; i++)
            {
                arr[i] = int.Parse(arrStr[i]);
            }

            arr = SortedArrayTools.RemoveDuplicates(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
    public static class SortedArrayTools
    {
        public static int[] RemoveDuplicates(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentException("Empty array");
            }
            int n = 1, current = arr[0], j = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    throw new ArgumentException("Negative element");
                }

                if (arr[i] < current)
                {
                    throw new ArgumentException("Not sorted");
                }

                if (arr[i] == current)
                {
                    arr[i] = -arr[i]; // mark elems by negative sign
                }
                else
                {
                    current = arr[i];
                    n++;                // count uniques
                }
            }

            int[] result = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    result[j++] = arr[i];
                }
            }

            return result;
        }
    }
}
