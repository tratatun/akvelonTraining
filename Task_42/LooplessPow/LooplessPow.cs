using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LooplessPow
{
    public static class LooplessPow
    {
        public static bool IsNumberPowerOfTwo(int num)
        {
            return num != 0 && (num & (num - 1)) == 0;
        }
    }
}
