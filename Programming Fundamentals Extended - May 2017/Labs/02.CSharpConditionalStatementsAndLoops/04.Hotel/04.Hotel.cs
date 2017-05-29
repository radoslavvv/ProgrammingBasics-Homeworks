using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string month = Console.ReadLine();
        int nightsCount = int.Parse(Console.ReadLine());

        double studioPrice = 0;
        double doublePrice = 0;
        double suitePrice = 0;

        if (month == "May" || month == "October")
        {         
            if (nightsCount > 7)
            {
                if (month == "October")
                {
                    studioPrice = (nightsCount - 1) * 50;
                }
                else
                {
                    studioPrice = (nightsCount) * 50;
                }
                studioPrice -= studioPrice * 0.05;
            }
            else
            {
                studioPrice = nightsCount * 50;
            }
            doublePrice = nightsCount * 65;
            suitePrice = nightsCount * 75;
        }
        else if (month == "June" || month == "September")
        {
            if (nightsCount > 7 && month == "September")
            {
                studioPrice = (nightsCount - 1) * 60;
            }
            else
            {
                studioPrice = nightsCount * 60;
            }

            doublePrice = nightsCount * 72;

            if (nightsCount > 14)
            {
                doublePrice -= doublePrice * 0.10;
            }

            suitePrice = nightsCount * 82;
        }
        else if (month == "July" || month == "August" || month == "December")
        {
            studioPrice = nightsCount * 68;
            doublePrice = nightsCount * 77;
            suitePrice = nightsCount * 89;
            if (nightsCount > 14)
            {
                suitePrice -= suitePrice * 0.15;
            }
        }
        Console.WriteLine($"Studio: {studioPrice:0.00} lv.");
        Console.WriteLine($"Double: {doublePrice:0.00} lv.");
        Console.WriteLine($"Suite: {suitePrice:0.00} lv.");
    }
}


