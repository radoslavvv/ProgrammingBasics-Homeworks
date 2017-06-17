using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        bool areEqual = true;

        for (int i = 1; i < numbers.Length; i++)
        {
            int previousNumber = numbers[i - 1];
            int currentNumber = numbers[i];

            if (currentNumber != previousNumber)
            {
                areEqual = false;
                break;
            }
        }
        if (areEqual)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}

