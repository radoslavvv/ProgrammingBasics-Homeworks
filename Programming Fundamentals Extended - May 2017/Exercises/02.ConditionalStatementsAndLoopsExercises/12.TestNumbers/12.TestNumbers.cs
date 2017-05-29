using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());

        int combinationsCount = 0;
        int totalSum = 0;
        bool hasReachedMax = false;

        for (int i = firstNumber; i >= 1; i--)
        {
            for (int j = 1; j <= secondNumber; j++)
            {
                combinationsCount++;
                totalSum += (i * j) * 3;
                if (totalSum >= max)
                {
                    hasReachedMax = true;
                    break;
                } 
            }
            if (hasReachedMax)
            {
                break;
            }
        }
        Console.WriteLine($"{combinationsCount} combinations");
        if (hasReachedMax)
        {
            Console.WriteLine($"Sum: {totalSum} >= {max}");
        }
        else
        {
            Console.WriteLine($"Sum: {totalSum}");
        }
       
    }
}

