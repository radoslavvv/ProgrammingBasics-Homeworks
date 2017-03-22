using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CurrencyConverter
{
    static void Main()
    {
        double bgnCourse = 1.0;
        double usdCourse = 1.79549;
        double eurCourse = 1.95583;
        double gbpCourse = 2.53405;

        double value = double.Parse(Console.ReadLine());
        string type1 = Console.ReadLine();
        string type2 = Console.ReadLine();

        switch (type1)
        {
            case "USD":
                value *= usdCourse;
                break;

            case "EUR":
                value *= eurCourse;
                break;

            case "GBP":
                value *= gbpCourse;
                break;

            case "BGN":
                value *= bgnCourse;
                break;
        }

        switch (type2)
        {
            case "USD":
                value /= usdCourse;
                break;

            case "EUR":
                value /= eurCourse;
                break;

            case "GBP":
                value /= gbpCourse;
                break;

            case "BGN":
                value /= bgnCourse;
                break;
        }
        Console.WriteLine(Math.Round(value, 2) + " {0}", type2);
    }
}

