using System;

namespace PointInFigure
{
    class PointInFigure
    {
        static void Main()
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            bool isInsideHorizontal = (y > 0 && y < h) && ((x > 0 && x < 3 * h));
            bool isInsideVertical = ((x > h) && (x < (2 * h)) && ((y < 4 * h && y > 0)));

            bool isOutSideHorizontal = (x < 0 || x > 3 * h) || (y < 0 || y > 4 * h);
            bool isOutSideVertial = (y > h) && (x < h || x > 2 * h); 

            if (isInsideHorizontal || isInsideVertical)
            {
                Console.WriteLine("inside");
            }
            else if (isOutSideHorizontal || isOutSideVertial)
            {
                Console.WriteLine("outside");
            }
            else
            {
                Console.WriteLine("border");
            }
        }
    }
}
