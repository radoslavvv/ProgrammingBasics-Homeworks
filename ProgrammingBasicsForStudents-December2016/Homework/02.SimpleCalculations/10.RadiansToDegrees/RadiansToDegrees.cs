using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RadiansToDegrees
{
    static void Main()
    {
        double rad = double.Parse(Console.ReadLine());
        double deg = rad * (180 / Math.PI);

        Console.WriteLine(Math.Round(deg));
    }
}

