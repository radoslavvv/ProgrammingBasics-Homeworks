using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MilesToKilometers
{
    static void Main()
    {
        double milesCount = double.Parse(Console.ReadLine());
        double kilometersCount = milesCount * 1.60934;

        Console.WriteLine($"{kilometersCount:0.00}");
    }
}

