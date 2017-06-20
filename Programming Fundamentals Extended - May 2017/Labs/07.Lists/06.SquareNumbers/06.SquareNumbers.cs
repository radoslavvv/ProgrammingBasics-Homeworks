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
            .Split()
            .Select(double.Parse)
            .ToList();

        List<double> squareNumbers = new List<double>();

        for (int i = 0; i < numbers.Count; i++)
        {
            double currentNumber = numbers[i];
            if (Math.Sqrt(currentNumber) == (int) Math.Sqrt(currentNumber))
            {
                squareNumbers.Add(currentNumber);
            }
        }
        squareNumbers.Sort();
        squareNumbers.Reverse();

        Console.WriteLine(string.Join(" ",squareNumbers));
    }
}

