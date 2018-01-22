using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starter
{
    public class SortUsingTempArray
    {
        static void sort(int[] input, int k)
        {
            int[] temp = new int[k];
            int i, j, ind = 0;
            for (i = 0; i < input.Length; i++)
            {
                temp[input[i] – 1]++;
            }
            for (i = 0; i < k; i++)
            {
                if (temp[i] == 0)
                    continue;
                for (j = 0; j < temp[i]; j++)
                {
                    input[ind++] = (i + 1);
                }
            }
        }
        public static void main(String[] args)
        {
            int[] input = { 1, 2, 3, 2, 3, 1, 2, 3, 7, 1, 5 };
            sort(input, 7);
            for (int n : input)
            {
                System.out.println(n);
            }
        }
    }
}
