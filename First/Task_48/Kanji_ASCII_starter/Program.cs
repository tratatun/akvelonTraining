using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanji_ASCII_starter
{
    class Program
    {
        /*
         * First some definitions for this problem: 
           a) An ASCII character is one byte long and the most significant bit in the byte is always '0'. 
           b) A Kanji character is two bytes long. The only characteristic of a Kanji character is that in its first byte the most significant bit is '1'. 
           Now you are given an array of the characters (both ASCII and Kanji) and, an index into the array. The index points to the start of some character. 
           Now you need to write a function to do a backspace (i.e. delete the character before the given index).
         */
        static void Main(string[] args)
        {
            char[] cArr = new[] { '〄', 'ぁ', 'r', 'Ｋ' };
            byte[][] bArr = new byte[cArr.Length][];
            string[] sArrUnParsed = new string [cArr.Length];
            int i = 0;
            string[] sArr = cArr.SelectMany(c =>
            {
                string unicode = Convert.ToString(c, 2);
                unicode = new string('0', 16 - unicode.Length) + unicode;
                sArrUnParsed[i++]= unicode.Substring(0, 8) + "'" + unicode.Substring(8);
                return new[] {unicode.Substring(0, 8), unicode.Substring(8)};

            }).ToArray();
            //byte[] b2arr = Kanji_ASCII.Kanji_ASCII.Backspace(bArr);
            Console.WriteLine(string.Join("\n", sArrUnParsed));

            string someText = "ぁ The.";
            byte[] bytes = Encoding.Unicode.GetBytes(someText);
            char[] chars = Encoding.Unicode.GetChars(bytes);

            byte[] bytes1 = Encoding.UTF8.GetBytes(someText);
            char[] chars1 = Encoding.UTF8.GetChars(bytes);
            Console.ReadKey();
        }
    }
}
