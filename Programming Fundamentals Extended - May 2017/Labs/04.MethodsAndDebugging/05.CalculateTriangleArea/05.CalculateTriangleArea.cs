using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double area = CalculateArea(width, height);
        Console.WriteLine(area);
    }

    static double CalculateArea(double width, double height)
    {
        double area = width * height / 2;
        return area;
    }
}

