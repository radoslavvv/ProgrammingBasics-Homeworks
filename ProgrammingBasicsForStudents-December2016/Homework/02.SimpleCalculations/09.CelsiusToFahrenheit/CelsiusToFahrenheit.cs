using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CelsiusToFahrenheit
{
    static void Main()
    {
        double c = double.Parse(Console.ReadLine());

        double f = (c * 1.8) + 32;
        Console.WriteLine(f);
    }
}

