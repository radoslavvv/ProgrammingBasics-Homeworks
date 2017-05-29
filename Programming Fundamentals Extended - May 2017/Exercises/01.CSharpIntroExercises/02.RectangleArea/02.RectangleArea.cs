using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RectangleArea
{
    static void Main()
    {
        double height = double.Parse(Console.ReadLine());
        double width = double.Parse(Console.ReadLine());

        double area = height * width;

        Console.WriteLine($"{area:0.00}");
    }
}

