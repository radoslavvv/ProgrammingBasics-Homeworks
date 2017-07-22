using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Point
{
    public int X { get; set; }
    public int Y { get; set; }
}
class Box
{
    public Point UpperLeft { get; set; }
    public Point UpperRight { get; set; }
    public Point BottomLeft { get; set; }
    public Point BottomRight { get; set; }

    public static int CalculatePerimeter(int width, int height)
    {
        return height * 2 + width * 2;
    }

    public static int CalculateArea(int width, int height)
    {
        return width * height;
    }
}

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        while (input != "end")
        {
            List<string> tokens = input.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries).ToList();

            Box currentBox = new Box()
            {
                UpperLeft = new Point()
                {
                    X = int.Parse(tokens[0].Split(':')[0]),
                    Y = int.Parse(tokens[0].Split(':')[1]),
                },
                UpperRight = new Point()
                {
                    X = int.Parse(tokens[1].Split(':')[0]),
                    Y = int.Parse(tokens[1].Split(':')[1]),
                },
                BottomLeft = new Point()
                {
                    X = int.Parse(tokens[2].Split(':')[0]),
                    Y = int.Parse(tokens[2].Split(':')[1]),
                },
                BottomRight = new Point()
                {
                    X = int.Parse(tokens[3].Split(':')[0]),
                    Y = int.Parse(tokens[3].Split(':')[1]),
                }
            };

            int width = Distance(currentBox.UpperLeft, currentBox.UpperRight);
            int height = Distance(currentBox.UpperLeft, currentBox.BottomLeft);
                       
            Console.WriteLine($"Box: {width}, {height}");
            Console.WriteLine($"Perimeter: {Box.CalculatePerimeter(width, height)}");
            Console.WriteLine($"Area: {Box.CalculateArea(width, height)}");


            input = Console.ReadLine();
        }
    }

    private static int Distance(Point a, Point b)
    {
        return (int)Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));
    }
}

