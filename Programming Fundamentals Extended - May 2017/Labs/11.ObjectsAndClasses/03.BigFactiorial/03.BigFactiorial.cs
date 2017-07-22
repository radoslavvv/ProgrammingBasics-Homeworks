using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        BigInteger factorial = 1;

        for (int i = n; i > 0; i--)
        {
            factorial *= i;
        }
        Console.WriteLine(factorial);
    }
}

