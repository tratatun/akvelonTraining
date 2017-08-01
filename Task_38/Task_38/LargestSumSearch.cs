using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_38
{
    public static class LargestSumSearch
    {
        public static int[] FindLargestSum(int[] arr)
        {
            if (arr.Length == 0)
            {
                return new int[0];
            }

            int maxSum = arr[0], currSum = arr[0], start = 0, end = 0, startMax = 0, endMax = 0;

            for (int i = 1; i < arr.Length; i++)
            {

                if (arr[i] > arr[i] + currSum)
                {
                    currSum = arr[i];
                    start = end = i;
                }
                else
                {
                    currSum += arr[i];
                    end = i;
                }

                if (currSum > maxSum)
                {
                    maxSum = currSum;
                    startMax = start;
                    endMax = end;
                }
            }


            int[] subArr = new int[endMax - startMax + 1];

            Array.Copy(arr, startMax, subArr, 0, endMax - startMax + 1);

            return subArr;
        } 
    }
}
