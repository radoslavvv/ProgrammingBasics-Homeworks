using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int minNumber = int.MaxValue;

        foreach (var number in numbers)
        {
            if (number < minNumber)
            {
                minNumber = number;
            }
        }
        Console.WriteLine(minNumber);

    }
}

