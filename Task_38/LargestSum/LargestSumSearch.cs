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
            int totalSum = 0, 
                minSum = 0, 
                maxSum = int.MinValue, 
                start = 0, 
                end = 0, 
                minPos = -1;

            // Implementing Kaden's algorithm 
            for (int i = 0; i < arr.Length; i++)
            {

                totalSum += arr[i];

                int curr = totalSum - minSum;

                if (maxSum < curr)
                {   
                    maxSum = curr;
                    start = minPos;
                    end = i;
                }

                if (minSum > totalSum)
                {
                    minSum = totalSum;
                    minPos = i;
                }
            }
            int[] subArr = new int[end-start];

            Array.Copy(arr, start + 1, subArr, 0, end - start);

            return subArr;
        }
    }
}
