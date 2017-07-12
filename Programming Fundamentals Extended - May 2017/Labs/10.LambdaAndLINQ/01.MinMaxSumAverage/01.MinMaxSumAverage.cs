using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int linesCount = int.Parse(Console.ReadLine());
        List<int> numbers = new List<int>();

        for (int i = 0; i < linesCount; i++)
        {
             numbers.Add(int.Parse(Console.ReadLine()));    
        }
        Console.WriteLine($"Sum = {numbers.Sum()}");
        Console.WriteLine($"Min = {numbers.Min()}");
        Console.WriteLine($"Max = {numbers.Max()}");
        Console.WriteLine($"Average = {numbers.Average()}");

    }
}

