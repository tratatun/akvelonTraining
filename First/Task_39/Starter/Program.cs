using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 8, 7, 6, 5, 4,3, 2, 1, 1 };
            DuplicatesAnalizer.DuplicatesAnalizer.ShowDuplicates(arr);


            Console.ReadKey();
        }
    }
}
