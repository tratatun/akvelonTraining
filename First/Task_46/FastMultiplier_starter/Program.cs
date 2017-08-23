using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastMultiplier_starter
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = FastMultiplier.FastMultiplier.FastMultiplierTo7(4);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
