using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        double[] doubles = Console.ReadLine()
            .Split(' ')
            .Select(double.Parse)
            .ToArray();

        double multiplier = double.Parse(Console.ReadLine());


        for (int i = 0; i < doubles.Length; i++)
        {
            doubles[i] *= multiplier;
        }
        Console.WriteLine(string.Join(" ",doubles));
    }
}

