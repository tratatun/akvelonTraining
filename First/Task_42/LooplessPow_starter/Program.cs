using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooplessPow_starter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LooplessPow.LooplessPow.IsNumberPowerOfTwo(5));
            Console.WriteLine(LooplessPow.LooplessPow.IsNumberPowerOfTwo(2));
            Console.WriteLine(LooplessPow.LooplessPow.IsNumberPowerOfTwo(0));
            Console.WriteLine(LooplessPow.LooplessPow.IsNumberPowerOfTwo(4));
            Console.WriteLine(LooplessPow.LooplessPow.IsNumberPowerOfTwo(64));
            Console.WriteLine(LooplessPow.LooplessPow.IsNumberPowerOfTwo(96));
            Console.WriteLine(LooplessPow.LooplessPow.IsNumberPowerOfTwo(1024));
            Console.WriteLine(LooplessPow.LooplessPow.IsNumberPowerOfTwo(24));
            Console.WriteLine(LooplessPow.LooplessPow.IsNumberPowerOfTwo(512));
        }
    }
}
