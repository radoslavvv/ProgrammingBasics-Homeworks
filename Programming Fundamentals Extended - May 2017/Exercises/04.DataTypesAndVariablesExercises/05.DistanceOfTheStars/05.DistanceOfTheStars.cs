using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        decimal first = 4.22M * 9450000000000;
        decimal second = 26000 * 9450000000000;
        decimal third = 100000 * 9450000000000;
        decimal fourth = 46500000000m * 9450000000000m;

        Console.WriteLine($"{first:e2}");
        Console.WriteLine($"{second:e2}");
        Console.WriteLine($"{third:e2}");
        Console.WriteLine($"{fourth:e2}");
    }
}

