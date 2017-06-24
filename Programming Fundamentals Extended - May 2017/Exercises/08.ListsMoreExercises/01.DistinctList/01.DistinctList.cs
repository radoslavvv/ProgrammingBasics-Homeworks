using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        List<int> input = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        List<int> distinctElements = new List<int>();

        for (int i = 0; i < input.Count; i++)
        {
            if (!distinctElements.Contains(input[i]))
            {
                distinctElements.Add(input[i]);
            }
        }
        Console.WriteLine($"{string.Join(" ",distinctElements)}");
    }
}

