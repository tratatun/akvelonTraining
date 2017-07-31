using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_38
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = {-2, -3, -4, 1, -2, -1, -5, -3};
            int[] result = LargestSumSearch.FindLargestSum(test);
            string res = String.Empty;
            foreach (int i in result)
            {
                res += i.ToString() + " ";
            }
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
