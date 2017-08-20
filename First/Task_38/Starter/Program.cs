using System;

namespace LargestSum_starter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = {-2, -3, -4, 1, 2, -2, -5, -3};
            int[] result = new LargestSumSearch.LargestSumSearch(test).FindLargestSum();
            string res = String.Empty;
            foreach (int i in result)
            {
                res += i + " ";
            }
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
