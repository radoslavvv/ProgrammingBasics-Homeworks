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
        int sum = 0;
        for (int i = 0; i < arraySize; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            numbers[i] = currentNumber;
            sum += currentNumber;
        }
        Console.WriteLine(sum);
    }
}

