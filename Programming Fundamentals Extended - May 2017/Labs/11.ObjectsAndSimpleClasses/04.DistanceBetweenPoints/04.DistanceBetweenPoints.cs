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
        int[] firstPointParams = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Point firstPoint = new Point()
        {
            X = firstPointParams[0],
            Y = firstPointParams[1]
        };

        int[] secondPointParams = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Point secondPoint = new Point()
        {
            X = secondPointParams[0],
            Y = secondPointParams[1]
        };

        double distance = CalculateDistance(firstPoint, secondPoint);
        Console.WriteLine($"{distance:0.000}");
    }

    private static double CalculateDistance(Point a, Point b)
    {
        double distance = Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));

        return distance;
    }
}

