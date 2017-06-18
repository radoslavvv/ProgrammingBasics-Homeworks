using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        List<double> numbers = Console.ReadLine()
            .Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries)
            .Select(double.Parse)
            .ToList();

        numbers.Sort();

        Console.WriteLine(string.Join(" <= ",numbers));
    }
}

