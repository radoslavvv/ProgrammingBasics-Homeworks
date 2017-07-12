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

        int k = numbers.Count / 4;

        List<int> firstRow = numbers
            .Skip(k)
            .Take(k * 2)
            .ToList();

        List<int> secondRow = numbers
            .Take(k)
            .Reverse()
            .Concat(numbers.Skip(k * 3)
            .Reverse())
            .Select((x, index) => x + firstRow[index])
            .ToList();

        Console.WriteLine($"{string.Join(" ", secondRow)}");
    }
}

