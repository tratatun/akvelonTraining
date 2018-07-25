using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* "Prime" : "Not prime" */
        int count = int.Parse(Console.ReadLine());
        int[] n = new int[count];
        bool[] notPrime = new bool[count];
        for (int j = 0; j < count; j++)
        {
            n[j] = int.Parse(Console.ReadLine());
        }
        for (int j = 0; j < count; j++)
        {
            if (n[j] == 1)
            {
                notPrime[j] = true;
                continue;
            }
            double sq = Math.Sqrt(n[j]);
            for (int i = 2; i <= sq; i++)
            {
                if (n[j] % i == 0)
                    notPrime[j] = true;
            }
        }
        
        for (int j = 0; j < count; j++)
        {
            Console.WriteLine(!notPrime[j] ? "Prime" : "Not prime");
        }
        Console.ReadKey();
    }
}