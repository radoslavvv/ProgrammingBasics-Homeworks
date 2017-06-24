using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        int smallestElement = Int32.MaxValue;

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] < smallestElement)
            {
                smallestElement = numbers[i];
            }
        }
        Console.WriteLine(smallestElement);
    }
}

