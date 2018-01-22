using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicatesAnalizerExtraSpace
{
    public class DuplicatesAnalizerExtraSpace
    {
        public static int[] ShowDuplicates(int[] arr)
        {
            int resultLength = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= arr.Length || arr[i] == 0)
                    return null;

                if (arr[i] > arr[arr[i]])
                {
                    int tmp1 = arr[i];
                    int tmp2 = arr[arr[i]];
                    arr[arr[i]] = tmp1;
                    arr[i] = tmp2;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                int abs = arr[i];
                if (abs < 0)
                {
                    abs = -arr[i];
                }

                if (arr[abs] > 0)
                {
                    arr[abs] = -arr[abs];
                }
                else
                {
                    arr[abs] = 0;
                    resultLength++;
                }
            }

            int[] result = new int [resultLength];
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    result[j++] = i;
                }
            }

            return result;
        }
    }
}
