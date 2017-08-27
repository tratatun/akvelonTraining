using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCaseConverter
{
    public static class CharacterCaseConverter
    {
        public static char[] ToUpper(char[] lowerArray)
        {
            char[] arr = new char[lowerArray.Length];
            // Lower and upper cased characters differ by only one bit - 100000(2) or 32(10) or 20(16), lower has 1, upper has 0. 
            // So, in order to convert lower to upper we need to switch this bit to 0.
            arr = lowerArray.Select(c => (char)(c & ~0x20)).ToArray();

            return arr;
        }
    }
}
