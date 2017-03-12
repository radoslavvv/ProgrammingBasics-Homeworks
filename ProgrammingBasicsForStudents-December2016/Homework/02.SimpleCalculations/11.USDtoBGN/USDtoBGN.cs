using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class USDtoBGN
{
    static void Main()
    {
        double course = 1.79549;

        double usd = double.Parse(Console.ReadLine());
        double bng = usd * course;

        Console.WriteLine(Math.Round(bng, 2));
    }
}

