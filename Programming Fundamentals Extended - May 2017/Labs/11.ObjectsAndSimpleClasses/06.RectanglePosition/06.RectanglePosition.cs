using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Rectangle
{
    public int Top { get; set; }
    public int Left { get; set; }
    public int Right { get; set; }
    public int Bottom { get; set; }
}
class Program
{
    static void Main()
    {
        Rectangle firstRectangle = ReadRectangle();
        Rectangle secondRectangle = ReadRectangle();


        if (firstRectangle.Bottom <= secondRectangle.Bottom && firstRectangle.Top >= secondRectangle.Top &&
            firstRectangle.Right <= secondRectangle.Right && firstRectangle.Left >= secondRectangle.Left)
        {
            Console.WriteLine("Inside");
        }
        else
        {
            Console.WriteLine($"Not inside");
        }
    }

    private static Rectangle ReadRectangle()
    {
        int[] rectangleParams = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int left = rectangleParams[0];
        int top = rectangleParams[1];
        int width = rectangleParams[2];
        int height = rectangleParams[3];
        int right = left + width;
        int bottom = top + height;

        return new Rectangle()
        {
            Top = top,
            Left = left,
            Right = right,
            Bottom = bottom
        };
    }
}



