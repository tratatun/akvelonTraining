using System;
using System.Text;

namespace CharsArray_starter
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr = CharsArray.CharsArray.GetCharsArrayFromNum(-145);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine((int)(arr[i]));
            }
            Console.ReadKey();
        }
    }
}
