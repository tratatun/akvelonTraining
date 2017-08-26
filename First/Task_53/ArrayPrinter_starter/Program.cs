using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrinter_starter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[4,5];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = 10 * i + j;
                    Console.Write(arr[i,j]+"\t");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine(ArrayPrinter.SpiralOrder.Print(arr));

            
        }
    }
}
