using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrawTools;

namespace DrawTools_starter
{
    class Program
    {
        static void Main(string[] args)
        {
            int R = 10;
            List<Pixel> list = DrawTools.DrawTools.DrawCircle(R);

            string POINT = "*";

            foreach (Pixel pixel in list)
            {
                Console.SetCursorPosition(pixel.X + R + 1, pixel.Y + R + 1);
                Console.Write(POINT);
            }

            Console.SetCursorPosition(0,0);
            Console.ReadKey();

        }
    }
}
