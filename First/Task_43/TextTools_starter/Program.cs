using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextTools_starter
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr = "first second third fourth".ToCharArray();
            Console.WriteLine(TextTools.TextTools.ReverseSentence(arr));
            Console.ReadKey();
        }
    }
}
