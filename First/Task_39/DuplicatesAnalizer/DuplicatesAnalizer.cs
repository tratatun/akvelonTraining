﻿using System;

namespace DuplicatesAnalizer
{
    public static class DuplicatesAnalizer
    {
        public static int[] ShowDuplicates(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
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
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]==0)
                {
                    Console.Write(i);
                    Console.Write(i != arr.Length - 1 ? " " : "");
                }
            }

            return arr;
        }
    }
}
