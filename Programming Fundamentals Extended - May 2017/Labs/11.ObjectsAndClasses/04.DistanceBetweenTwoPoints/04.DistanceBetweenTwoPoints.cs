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

class Program
{
    static void Main()
    {
        Point firstPoint = ReadPoint();
        Point secondPoint = ReadPoint();

        double distance = CalculateDistanceBetweenPoints(firstPoint, secondPoint);

        Console.WriteLine($"{distance:0.000}");
    }

    private static double CalculateDistanceBetweenPoints(Point a, Point b)
    {
        double distance = Math.Sqrt(Math.Pow(Math.Abs(a.X - b.X), 2) + Math.Pow(Math.Abs(a.Y - b.Y), 2));

        return distance;
    }

    private static Point ReadPoint()
    {
        List<int> parameters = Console.ReadLine().Split().Select(int.Parse).ToList();

        Point point = new Point()
        {
            X = parameters[0],
            Y = parameters[1],
        };
        return point;
    }
}

