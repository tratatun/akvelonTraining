using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawTools
{
    public static class DrawTools
    {
        public static List<Pixel> DrawCircle(int R)
        {
            if (R <= 0)
            {
                return new List<Pixel>();
            }
            int x = 0;
            int y = R;
            int delta = 1 - 2 * R;
            int err = 0;
            List<Pixel> circle = new List<Pixel>();
            while (y >= 0)
            {
                circle.Add(new Pixel(x, y));
                circle.Add(new Pixel(x, -y));
                circle.Add(new Pixel(-x, y));
                circle.Add(new Pixel(-x, -y));

                err = 2 * (delta + y) - 1;
                if (delta < 0 && err <= 0)
                {
                    delta += 2 * ++x + 1;
                    continue;
                }

                err = 2 * (delta - x) + 1;
                if (delta > 0 && err > 0)
                {
                    delta += 1 - 2 * --y;
                    continue;
                }

                x++;

                delta += 2 * (x - y);

                y--;
            }

            return circle;
        }
    }
}
