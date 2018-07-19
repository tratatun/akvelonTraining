﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciLessNum
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            WriteFibonacci(n);
            Console.ReadLine();
        }

        public static long[] GetFibonacciArr(int n)
        {
            // make array be ready for n == 0
            long[] arr = new long[n + 2];
            arr[0] = 0;
            arr[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                if (arr[i - 2] > long.MaxValue - arr[i - 1])
                {
                    arr[i] = long.MaxValue;
                }
                else
                {
                    arr[i] = arr[i - 1] + arr[i - 2];
                }
            }

            return arr;
        }

        public static string WriteFibonacciNumbers(int n)
        {
            // make array be ready for n == 0
            long a = 0, b = 1, c = 0;
            StringBuilder result = new StringBuilder(a.ToString());
            if (n < 1)
            {
                return "0";
            }

            result.Append(" " + b);

            for (int i = 2; i <= n; i++)
            {

                if (a > long.MaxValue - b)
                {
                    //handle type oversize
                    c = long.MaxValue;
                }
                else
                {
                    c = a + b;
                    a = b;
                    b++;
                    result.Append(" " + c);
                }

            }

            return result.ToString();
        }

        public static void WriteFibonacci(int n)
        {
            long[] arr = GetFibonacciArr(n);
            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.Write(arr[i] + " (" + i + "), ");
            }
        }
    }
}
