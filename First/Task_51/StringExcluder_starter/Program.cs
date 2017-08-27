using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExcluder_starter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringExcluder.StringExcluder.TrivialExludeCharacters("ad", "qweasdf"));
            Console.ReadKey();
        }
    }
}
