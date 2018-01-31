using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareArraySubSums
{
    public static class Program
    {
        //Write a program to display numbers having sum of left side numbers equal to right side numbers.Eg. {1,0,-11,1,12}=>0 {Left side number 1+0=1, Right side number -11+1+12=1}.

        public static void Main(string[] args)
        {
            try
            {
                string[] arrStr = Console.ReadLine().Split(' ');
                int[] arr = new int[arrStr.Length];
                int mid = int.Parse(Console.ReadLine());

                if (arrStr.Length == 0)
                {
                    throw new Exception("Wrong Input");
                }

                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = int.Parse(arrStr[i]);
                }

                Console.WriteLine(CheckArraySubSums(arr, mid));
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);

            }

        }

        public static bool CheckArraySubSums(int[] arr, int mid)
        {

            int sum1 = 0, sum2 = 0, midInd = 0;
            if (arr.Length == 0)
            {
                throw new Exception("Wrong Input: empty array");

            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (midInd == 0 && mid == arr[i])
                {
                    midInd = i;
                }
                else if (mid == arr[i])
                {
                    throw new Exception("Wrong Input: multiple middles");
                }
            }

            if (arr[0] == mid || arr[arr.Length - 1] == mid)
            {
                return false;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (i < midInd)
                {
                    sum1 += arr[i];
                }

                if (midInd + i < arr.Length)
                {
                    sum2 += arr[midInd + i];
                }
            }

            return sum1 == sum2;

        }
    }
}
