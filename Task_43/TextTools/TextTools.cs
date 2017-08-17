using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextTools
{
    public static class TextTools
    {
        public static char[] ReverseSentence(char[] arr)
        {
            if (arr == null)
            {
                return null;
            }

            int cur = 0, n = 0, len = 0, revIndex = 0;
            int[] indxs = new int[arr.Length];
            char[] result = new char[arr.Length];

            while (cur < arr.Length)
            {
                if (arr[cur] == ' ')
                {
                    indxs[n++] = cur;
                }
                cur++;
            }

            cur = 0;

            for (var i = 0; i < arr.Length; i++)
            {
                if (arr[i] != ' ')
                {
                    if (cur < n)
                    {
                        revIndex = arr.Length - indxs[cur] + i - len;
                    }
                    else
                    {
                        revIndex =  i - len;
                    }
                    result[revIndex] = arr[i];
                }
                else
                {
                    result[arr.Length - indxs[cur++] - 1] = ' ';
                    len = i + 1;
                }
            }

            return result;
        }
    }
}
