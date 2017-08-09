using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextTools
{
    public class TextTools
    {
        public static string ReverseSentence(string str)
        {
            if (str == null)
            {
                return null;
            }
            string[] arr = str.Split(' ');
            string result = String.Empty;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                result += arr[i] + " ";
            }
            return result.TrimEnd();
        }
    }
}
