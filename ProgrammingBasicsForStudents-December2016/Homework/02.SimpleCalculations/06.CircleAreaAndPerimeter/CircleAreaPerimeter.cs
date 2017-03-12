using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CircleAreaPerimeter
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());
        double area = Math.PI * r * r;
        double perimeter = 2 * Math.PI * r;

        Console.WriteLine(area + "\n" + perimeter);
    }
}

