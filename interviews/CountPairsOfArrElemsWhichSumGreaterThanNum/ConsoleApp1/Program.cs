using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class PairTools
    {

        public static void Main(string[] args)
        {
            string[] arrStr = Console.ReadLine().Split(' ');
            int sum = int.Parse(Console.ReadLine());
            int[] arr = new int [arrStr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(arrStr[i]);
            }
            int result = 0;
            result = PairCounter(arr, sum);
            Console.WriteLine(result);

        }

        public static int PairCounter(int[] arr, int sum, int start = -1, int end = -1, int result = -1)
        {
            if (arr.Length == 0)
            {
                return -1;
            }
            if (start == -1 || end == -1 || result == -1)
            {
                start = 0;
                end = arr.Length - 1;
                result = 0;
            }
            if (start == end)
            {
                return result;
            }
            if (arr[start] + arr[end] >= sum)
            {
                result += end - start;
                end--;
            }
            else
            {
                start++;
            }
            return PairCounter(arr, sum, start, end, result);
        }
    }

}
