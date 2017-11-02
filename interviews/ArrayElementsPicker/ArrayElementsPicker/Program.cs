using System;

/*
 Given an Array A with n elements. Pick maximum number of elements from given array following the rule:  We cannot pick A[i] and A[j] if absolute value of (A[i] - A[j]) > absolute value of (i - j) 

Example: {13,5,4} 
Ans: 2 
Pick 5 and 4.
*/
namespace ArrayElementsPicker
{
    public class Program
    {
        public static void Main(string [] args)
        {
            string[] strarr = Console.ReadLine().Split(' ');
            int[] arr = new int[strarr.Length]; //
            

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(strarr[i]);
            }

            int[][]res = ArrayElementsPicker.PickElemByRule(arr);

        }

    }

    public static class ArrayElementsPicker
    {
        public static int[][] PickElemByRule(int[] arr)
        {
            int[][] result = new int[arr.Length * arr.Length][],clearResult;
            int k = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int sum = arr[i] - arr[j], indSum = i - j;
                    sum = sum < 0 ? -sum : sum;
                    indSum = indSum < 0 ? -indSum : indSum;

                    if (sum <= indSum)
                    {
                        result[k] = new int[2];
                        result[k][0] = arr[i];
                        result[k++][1] = arr[j];
                    }
                }
            }
            clearResult=new int[k][];
            for (int i = 0; i < k; i++)
            {
                clearResult[i] = result[i];
            }

            return clearResult;
        }

    }
}