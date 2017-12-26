using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequences
{
    public static class SequenceOfNumbers
    {
        public static string WriteSequence(int n)
        {
            string res = string.Empty;
            int p = n;
            if (n >= 1 && n <= 100)
            {
                for (int i = 1; i <= n; i += 2)
                {
                    int k = (i - 1) * n + 1;
                    for (int j = 0; j < n - 1; j++)
                    {
                        res += k + "*";
                        k++;
                    }

                    res += k + "\n";
                }

                if (n % 2 != 0)
                {
                    p = n - 1;
                }

                for (int i = p; i > 0; i -= 2)
                {
                    int k = (i - 1) * n + 1;
                    for (int j = 0; j < n - 1; j++)
                    {
                        res += k + "*";
                        k++;
                    }

                    res += k + "\n";

                }
            }
            else
            {
                res = "Invalid Input!";
            }

            return res;
        }
    }
}
