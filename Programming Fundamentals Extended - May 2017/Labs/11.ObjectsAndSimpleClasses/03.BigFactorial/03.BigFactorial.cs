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
        BigInteger factoriel = 1;

        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            factoriel *= i;
        }
        Console.WriteLine(factoriel);
    }
}

