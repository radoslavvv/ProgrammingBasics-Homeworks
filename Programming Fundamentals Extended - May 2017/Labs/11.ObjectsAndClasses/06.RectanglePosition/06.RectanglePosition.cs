using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Rectangle
{
    public int Top { get; set; }
    public int Left { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public int Right { get; set; }
    public int Bottom { get; set; }
}
class Program
{
    static void Main()
    {
        Rectangle firstRectangle = ReadRectangle();
        Rectangle secondRectangle = ReadRectangle();

        Console.WriteLine(IsInside(firstRectangle, secondRectangle) ? "Inside" : "Not inside");
    }

    private static Rectangle ReadRectangle()
    {
        int[] firstLine = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Rectangle firstRectangle = new Rectangle()
        {
            Left = firstLine[0],
            Top = firstLine[1],
            Width = firstLine[2],
            Height = firstLine[3],
            Right = firstLine[0] + firstLine[2],
            Bottom = firstLine[1] + firstLine[3],
        };
        return firstRectangle;
    }

    private static bool IsInside(Rectangle a, Rectangle b)
    {
        if (a.Left >= b.Left && a.Right <= b.Right && a.Top <= b.Top && a.Bottom <= b.Bottom)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

