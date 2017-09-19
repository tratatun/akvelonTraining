using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsShuffler
{
    public static class CardsShuffler
    {
        public static int[] Shuffle()
        {
            int[] cardsPack =
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28,
                29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52
            };
            int[] result = new int[cardsPack.Length];

            for (int i = 0; i < 52; i++)
            {
                int index = DateTime.Now.Millisecond * i % 52;
                if (cardsPack[index] != -1)
                {
                    result[i] = cardsPack[index];
                    cardsPack[index] = -1;
                }
                else
                {
                    
                }
            }

            return result;
        }

        private static int GetNextIndex(int index)
        {
            return index;
        }
    }
}
