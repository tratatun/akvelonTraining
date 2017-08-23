using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastMultiplier
{
    public static class FastMultiplier
    {
        public static int FastMultiplierTo7(int num)
        {
            int result = (num << 3) - num;
            return result;
        }
    }
}
