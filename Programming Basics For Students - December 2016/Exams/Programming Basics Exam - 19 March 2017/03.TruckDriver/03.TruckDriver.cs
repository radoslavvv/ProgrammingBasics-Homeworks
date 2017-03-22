using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TruckDriver
{
    static void Main()
    {
        string season = Console.ReadLine();
        double kilometersCount = double.Parse(Console.ReadLine());

        double finalPrice = 0;

        if (season == "Spring" || season == "Autumn")
        {
            if (kilometersCount <= 5000) finalPrice = 0.75 * kilometersCount;
            else if (kilometersCount <= 10000) finalPrice = 0.95 * kilometersCount;
            else if (kilometersCount <= 20000) finalPrice = 1.45 * kilometersCount;

        }
        else if (season == "Summer")
        {
            if (kilometersCount <= 5000) finalPrice = 0.90 * kilometersCount;
            else if (kilometersCount <= 10000) finalPrice = 1.10 * kilometersCount;
            else if (kilometersCount <= 20000) finalPrice = 1.45 * kilometersCount;
        }
        else if (season == "Winter")
        {
            if (kilometersCount <= 5000) finalPrice = 1.05 * kilometersCount;
            else if (kilometersCount <= 10000) finalPrice = 1.25 * kilometersCount;
            else if (kilometersCount <= 20000) finalPrice = 1.45 * kilometersCount;
        }

        finalPrice *= 4;
        finalPrice -= finalPrice * 0.10;
        Console.WriteLine("{0:0.00}", finalPrice);
    }
}

