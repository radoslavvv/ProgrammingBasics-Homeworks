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

        int n = int.Parse(Console.ReadLine());

        List<int> result = new List<int>();

        for (int i = 1; i < numbers.Count; i++)
        {
            int currentNumber = numbers[i];
            int index = i - 1;

            while (index >= 0 && currentNumber > numbers[index])
            {
                numbers[index + 1] = numbers[index];
                index--;
            }
            numbers[index + 1] = currentNumber;
        }
       
        for (int i = 0; i < n; i++)
        {
            result.Add(numbers[i]);
        }
        Console.WriteLine($"{string.Join(" ",result)}");
    }
}

