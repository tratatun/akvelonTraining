using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string [] arrStr = str.Split(' ');
            int[] arr = new int[arrStr.Length], result;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(arrStr[i]);
            }

            result = CalculateSubNumber.Calculate(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

        }
    }

    public static class CalculateSubNumber
    {
        public static int[] Calculate(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int currentSum = calcElement(arr, i, arr[i], 0);

                /*for(int j = i+1;j<arr.Length;j++){

                    if(arr[j]>arr[i]){
                        currentSum++;
                    }
                }*/

                arr[i] = currentSum;

            }
            return arr;
        }

        public static int calcElement(int[] arr, int index, int elem, int sum)
        {
            if (index >= arr.Length)
            {
                return sum;
            }
            if (arr[index] > elem)
            {
                return calcElement(arr, index + 1, elem, sum + 1);
            }
            else
            {
                return calcElement(arr, index + 1, elem, sum);
            }
        }

    }



}
