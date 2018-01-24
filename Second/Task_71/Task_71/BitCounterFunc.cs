using System;

namespace Task_71
{
    public static class BitCounterFunc
    {
        /*
         * Let f(k) = y where k is the y-th number in the increasing sequence of non-negative integers
         * with the same number of ones in its binary representation as y, e.g. f(1) = 1, f(2) = 2, f(3) = 1, f(4) = 3, f(5) = 2, f(6) = 3 and so on.
         * Given k >= 0, compute f(k).
         */
        public static int F(int k)
        {
            int result = 1;
            int count = 0;
            int comparer = k;
            if (k < 0)
            {
                throw new ArgumentException("Input is negative");
            }
            while (comparer > 0)
            {
                count += comparer & 1;
                comparer = comparer >> 1;
            }

            for (int i = 0; i < k; i++)
            {
                comparer = i;
                int countI = 0;
                while (comparer > 0)
                {
                    countI += comparer & 1;
                    comparer = comparer >> 1;
                }

                if (countI == count)
                {
                    result++;
                }
            }

            return result;
        }
    }
}