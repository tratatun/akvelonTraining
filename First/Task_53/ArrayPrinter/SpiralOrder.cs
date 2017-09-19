using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrinter
{
    public static class SpiralOrder
    {
        public static string Print(int[,] arr)
        {
            string result = String.Empty;
            int h = 0, w = 0, i = 0, downEdge = 0, rightEdge = 0, upEdge = 0, leftEdge = 1;
            Direction direction = Direction.Down;
            while (i < arr.LongLength)
            {
                if (direction == Direction.Down)
                    if (h < arr.GetLength(0) - downEdge)
                    {
                        result += arr[h++, w] + " ";
                        i++;
                    }
                    else
                    {
                        downEdge++;
                        h--;
                        w++;
                        direction = Direction.Right;
                    }
                else if (direction == Direction.Right)
                {
                    if (w < arr.GetLength(1) - rightEdge)
                    {
                        result += arr[h, w++] + " ";
                        i++;
                    }
                    else
                    {
                        rightEdge++;
                        w--;
                        h--;
                        direction = Direction.Up;
                    }
                }
                else if (direction == Direction.Up)
                {
                    if (h >= 0 + upEdge)
                    {
                        result += arr[h--, w] + " ";
                        i++;
                    }
                    else
                    {
                        upEdge++;
                        h++;
                        w--;
                        direction = Direction.Left;
                    }
                }
                else if (direction == Direction.Left)
                {
                    if (w >= 0 + leftEdge)
                    {
                        result += arr[h, w--] + " ";
                        i++;
                    }
                    else
                    {
                        leftEdge++;
                        w++;
                        h++;
                        direction = Direction.Down;
                    }
                }
            }
            return result.TrimEnd();
        }
    }
}
