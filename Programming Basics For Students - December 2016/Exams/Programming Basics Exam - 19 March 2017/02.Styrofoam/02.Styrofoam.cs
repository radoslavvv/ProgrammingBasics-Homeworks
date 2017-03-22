using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Styrofoam
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        double houseArea = double.Parse(Console.ReadLine());
        double windowsCount = double.Parse(Console.ReadLine());
        double packageCount = double.Parse(Console.ReadLine());
        double packagePrice = double.Parse(Console.ReadLine());

        houseArea -= windowsCount * 2.4;
        houseArea += houseArea * 0.10;

        double packagesNeeded = Math.Ceiling(houseArea / packageCount) * packagePrice;

        if (packagesNeeded > budget)
        {
            Console.WriteLine("Need more: {0:0.00}", packagesNeeded - budget);

        }
        else
        {
            Console.WriteLine("Spent: {0:0.00}", packagesNeeded);
            Console.WriteLine("Left: {0:0.00}", budget - packagesNeeded);
        }

    }
}

