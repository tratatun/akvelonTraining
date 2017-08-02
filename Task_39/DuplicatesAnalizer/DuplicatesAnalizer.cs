using System;

namespace DuplicatesAnalizer
{
    public static class DuplicatesAnalizer
    {
        public static string ShowDuplicates(int[] arr)
        {
            string result = String.Empty;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] <= 0 || arr[i] > arr.Length)
                {
                    throw new ArgumentException("values must be between 1 and the array length");
                }
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
                    result += abs + " ";
                }
            }

            return result.TrimEnd();
        }
    }
}
