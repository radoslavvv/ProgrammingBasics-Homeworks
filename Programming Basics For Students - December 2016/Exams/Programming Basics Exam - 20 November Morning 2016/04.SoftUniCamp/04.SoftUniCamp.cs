using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SoftUniCamp
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        double carCount = 0;
        double microBusCount = 0;
        double smallBusCount = 0;
        double bigBusCount = 0;
        double trainCount = 0;
        double totalCount = 0;

        for (int i = 0; i < n; i++)
        {
            double numberOfPeople = double.Parse(Console.ReadLine());

            totalCount += numberOfPeople;

            if (numberOfPeople > 40)
            {
                trainCount += numberOfPeople;
            }
            else if (numberOfPeople <= 5)
            {
                carCount += numberOfPeople;
            }
            else if (numberOfPeople > 5 && numberOfPeople <= 12)
            {
                microBusCount += numberOfPeople;
            }
            else if (numberOfPeople > 12 && numberOfPeople <= 25)
            {
                smallBusCount += numberOfPeople;
            }
            else if (numberOfPeople > 25 && numberOfPeople <= 40)
            {
                bigBusCount += numberOfPeople;
            }
        }

        Console.WriteLine("{0:0.00}%", (carCount / totalCount) * 100);
        Console.WriteLine("{0:0.00}%", microBusCount / totalCount * 100);
        Console.WriteLine("{0:0.00}%", smallBusCount / totalCount * 100);
        Console.WriteLine("{0:0.00}%", bigBusCount / totalCount * 100);
        Console.WriteLine("{0:0.00}%", trainCount / totalCount * 100);
    }
}

