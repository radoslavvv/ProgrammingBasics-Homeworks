using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int searchedElement = int.Parse(Console.ReadLine());

        int ocurrencesCount = 0;

        foreach (var number in numbers)
        {
            if (number == searchedElement)
            {
                ocurrencesCount++;
            }
        }
        Console.WriteLine(ocurrencesCount);
    }
}

