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
        int pointsCount = int.Parse(Console.ReadLine());

        List<Point> points = ReadPoints(pointsCount);

        double minDistance = double.MaxValue;
        List<Point> closestPoints = FindClosestPoints(points, ref minDistance);

        PrintClosestPointsAndDistance(minDistance, closestPoints);
    }

    private static void PrintClosestPointsAndDistance(double minDistance, List<Point> closestPoints)
    {
        Console.WriteLine($"{minDistance:0.000}");
        Console.WriteLine($"({closestPoints[0].X}, {closestPoints[0].Y})");
        Console.WriteLine($"({closestPoints[1].X}, {closestPoints[1].Y})");
    }

    private static List<Point> FindClosestPoints(List<Point> points, ref double minDistance)
    {
        List<Point> closestPoints = new List<Point>();
        for (int i = 0; i < points.Count; i++)
        {
            for (int j = i + 1; j < points.Count; j++)
            {
                double currentDistance = CalculateDistanceBetweenPoints(points[i], points[j]);

                if (currentDistance < minDistance)
                {
                    minDistance = currentDistance;
                    closestPoints.Clear();
                    closestPoints.Add(points[i]);
                    closestPoints.Add(points[j]);
                }
            }
        }

        return closestPoints;
    }

    private static List<Point> ReadPoints(int pointsCount)
    {
        List<Point> points = new List<Point>();
        for (int i = 0; i < pointsCount; i++)
        {
            Point currentPoint = ReadPoint();
            points.Add(currentPoint);
        }
        return points;
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

