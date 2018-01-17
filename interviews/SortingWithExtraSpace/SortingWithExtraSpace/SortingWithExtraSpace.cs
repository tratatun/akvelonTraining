using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingWithExtraSpace
{
    public static class SortingWithExtraSpace
    {
        // Sort an array of size n containing integers between 1 and K, given a temporary scratch integer array of size K.

        public static int[] Sort(int[] arr, int K)
        {
            int n = arr.Length;
            int[] arrK = new int[K];
            if (n <= K) // means that we don't have doplicates
            {
                for (int i = 0; i < n; i++)
                {
                    if (arr[i] < 1 || arr[i] > K)
                    {
                        throw new Exception("Wrong input");
                    }

                    arrK[arr[i] - 1]--;
                }

                int j = 0;
                for (int i = 0; i < K; i++)
                {
                    if (arrK[j]++ < 0)
                    {
                        arr[j++] = i + 1;
                    }
                }
            }
            else if (n > K)
            {
                for (int i = 0; i < n; i++)
                {
                    if (arr[i] < 1 || arr[i] > K)
                    {
                        throw new Exception("Wrong input");
                    }

                    arrK[arr[i] - 1]--;
                }

                int j = 0;
                for (int i = 0; i < n; i++)
                {
                    if (arrK[j]++ < -1)
                    {
                        arr[i] = j+1;
                    }
                    else
                    {
                        arr[i] = j++ + 1;
                    }
                }
            }

            return arr;
        }
    }
}
