using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class Program
{
    static void Main()
    {
        decimal terabytes = decimal.Parse(Console.ReadLine());
        decimal bytes = (terabytes * 8796093022208m);
        Console.WriteLine($"{bytes:00}");
    }
}

