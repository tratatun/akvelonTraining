using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sequences;

namespace ConsoleApp1
{
    /*
        You should print below number sequence 
       
       If(n=3) 
       then 
       1*2*3 
       7*8*9 
       4*5*6 
       
       if n=5 
       1*2*3*4*5 
       11*12*13*14*15 
       21*22*23*24*25 
       16*17*18*19*20 
       6*7*8*9*10 
       
       Can anyone also tell me what kind of pattern it is? Implement code.
*/
    public class main
    {
        public static int Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string result = SequenceOfNumbers.WriteSequence(n);
            Console.WriteLine(result);
            Console.ReadKey();
            return 0;
        }
    }
}
