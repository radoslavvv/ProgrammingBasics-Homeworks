using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class InchesToCentimeters
{
    static void Main()
    {
        var number = double.Parse(Console.ReadLine());
        var numberInInches = number * 2.54;

        Console.WriteLine(numberInInches);
    }
}

