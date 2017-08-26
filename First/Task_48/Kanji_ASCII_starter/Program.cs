using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanji_ASCII_starter
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] cArr = new[] { '丈', '且', 'r' };
            byte[] bArr = {Convert.ToByte('r')};
            string[] sArr = cArr.SelectMany(c =>
            {
                string unicode = Convert.ToString(c, 2);
                unicode = new string('0', 16 - unicode.Length) + unicode;
                return new[] {unicode.Substring(0, 8), unicode.Substring(8)};

            }).ToArray();
            //byte[] b2arr = Kanji_ASCII.Kanji_ASCII.Backspace(bArr);
            //Console.WriteLine(b2arr);
        }
    }
}
