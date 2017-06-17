using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        bool isIncreasing = true;

        for (int i = 1; i < numbers.Length; i++)
        {
            int previousElement = numbers[i - 1];
            int currentElement = numbers[i];

            if (currentElement < previousElement)
            {
                isIncreasing = false;
                break;
            }
        }
        if (isIncreasing)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}

