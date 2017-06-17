using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int arraySize = int.Parse(Console.ReadLine());

        int[] numbers = new int[arraySize];
        for (int i = 0; i < arraySize; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int negativeCount = 0;
        foreach (var number in numbers)
        {
            if (number < 0)
            {
                negativeCount++;
            }
        }
        Console.WriteLine(negativeCount);
    }
}

