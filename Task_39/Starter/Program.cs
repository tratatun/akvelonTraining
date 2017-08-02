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
            int[] arr = {1, 2, 4, 2, 5, 1};
            string result = DuplicatesAnalizer.DuplicatesAnalizer.ShowDuplicates(arr);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
