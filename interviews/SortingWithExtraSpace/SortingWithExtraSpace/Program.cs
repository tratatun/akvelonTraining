using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingWithExtraSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] inputStr = Console.ReadLine().Split(' ');
            int K = int.Parse(Console.ReadLine());
            int [] input =new int[inputStr.Length], result;

            for(int i =0; i<input.Length; i++)
            {
                input[i] = int.Parse(inputStr[i]);
            }

            result = SortingWithExtraSpace.Sort(input, K);

            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
