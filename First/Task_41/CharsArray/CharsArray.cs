using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharsArray
{
    public static class CharsArray
    {
        public static char[] GetCharsArrayFromNum(int num)
        {
            int tenPow = 10, len = 1, rank = 10, abs = num, firstDigitIndex = 0;
            bool isNegative = false;
            char[] arr;
            if (num < 0)
            {
                abs = -num;
                isNegative = true;
            }
            while (rank <= abs)
            {
                len++;
                rank *= 10;
            }

            if (isNegative)
            {
                len++;
                arr = new char[len];
                arr[0] = '-';
                firstDigitIndex = 1;
            }
            else
            {
                arr = new char[len];
            }

            for (int i = len-1; i >= firstDigitIndex; i--)
            {
                // 48 is a charcode of '0' 
                arr[i] = (char) (abs % tenPow / (tenPow / 10) + 48);
                tenPow *= 10;
            }

            return arr;
        }
    }
}
