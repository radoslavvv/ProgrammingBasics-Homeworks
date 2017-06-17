using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
        double searchedElement = double.Parse(Console.ReadLine());

        int ocurrencesCount = 0;

        foreach (var number in numbers)
        {
            if (number > searchedElement)
            {
                ocurrencesCount++;
            }
        }
        Console.WriteLine(ocurrencesCount);
    }
}

