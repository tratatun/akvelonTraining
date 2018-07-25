using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQTest
{
    public class Program
    {
        /*
        Bob is preparing to pass IQ test. The most frequent task in this test is to find out which one of the given numbers differs from the others. 
        Bob observed that one number usually differs from the others in evenness. Help Bob — to check his answers, 
        he needs a program that among the given numbers finds one that is different in evenness, and return a position of this number.

        ! Keep in mind that your task is to help Bob solve a real IQ test, which means indexes of the elements start from 1 (not 0)

        ##Examples :

        IQ.Test("2 4 7 8 10") => 3 // Third number is odd, while the rest of the numbers are even

        IQ.Test("1 2 1 1") => 2 // Second number is even, while the rest of the numbers are odd

         */
        static void Main(string[] args)
        {
            //Console.WriteLine(Test("2 4 7 8 10"));
            //Console.WriteLine(Test("1 2 1 1"));
            Console.WriteLine(Test("1 2 2"));
        }
        public static int Test(string numbers)
        {
            string[] strArr = numbers.Split(' ');
            if (numbers == null || strArr.Length == 0)
            {
                return 0;
            }

            //Your code is here...

            int numEven = 0, numOdd = 0, idxEven = -1, idxOdd = -1;
            bool isOdd = strArr[0][strArr[0].Length-1] % 2 != 0, found = false;
            for (int i = 0; i < strArr.Length; i++)
            {
                if (strArr[i][strArr[i].Length - 1] % 2 != 0)
                {
                    numOdd++;
                    idxOdd = idxOdd == -1 ? i : idxOdd;
                }
                else
                {
                    numEven++;
                    idxEven = idxEven == -1 ? i : idxEven;
                }

            }
            if (numOdd > numEven)
            {
                return idxEven + 1;
            }
            else
            {
                return idxOdd + 1;
            }
        }
    }
}
