using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        // 58. Given an array of length N containing integers between 1 and N, determine if it contains any duplicates.
        static void Main(string[] args)
        {
            string[] arrStr = Console.ReadLine().Split(' ');
            int[] arr = new int[arrStr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(arrStr[i]);
            }


        }

        // solution with modifying given array
        public static bool CheckForDuplicates_ByModifyArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > arr.Length || arr[i] < 1)
                {
                    throw new ArgumentException("Wrong Input");
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                int abs = arr[i] < 0 ? -arr[i] : arr[i];
                int compareElem = abs == n || abs == -n ? n : arr[abs];
                if (compareElem < 0)
                {
                    return true;
                }
                if (abs == n)
                {
                    n = -n;
                }
                else
                {
                    arr[abs] = -arr[abs];
                }
            }

            return false;
        }

        // solution with using extra space
        public static bool CheckForDuplicates_ByExtraSpace(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > arr.Length || arr[i] < 1)
                {
                    throw new ArgumentException("Wrong Input");
                }
            }

            int[] arrExtra = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                int abs = arr[i] < 0 ? -arr[i] : arr[i];
                int compareElem = abs == n || abs == -n ? n : arrExtra[abs];
                if (compareElem < 0)
                {
                    return true;
                }

                if (abs == n)
                {
                    n = -n;
                }
                else
                {
                    arrExtra[abs] = -arr[abs];
                }

            }

            return false;
        }
    }
}
