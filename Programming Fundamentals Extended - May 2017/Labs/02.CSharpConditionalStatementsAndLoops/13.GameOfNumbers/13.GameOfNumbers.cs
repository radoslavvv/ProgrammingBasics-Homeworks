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
        int magicalNumber = int.Parse(Console.ReadLine());

        string lastSum = string.Empty;
        bool combinationFound = false;
        int combinationsCount = 0;

        for (int i = firstNumber; i <= secondNumber; i++)
        {
            for (int j = firstNumber; j <= secondNumber; j++)
            {              
                int sum = i + j;
                if (sum == magicalNumber)
                {
                    lastSum = $"{i} + {j} = {magicalNumber}";
                    combinationFound = true;
                }
                combinationsCount++;
            }
        }
        if (combinationFound)
        {
            Console.WriteLine($"Number found! {lastSum}");
        }
        else
        {
            Console.WriteLine($"{combinationsCount} combinations - neither equals {magicalNumber}");
        }
   }
}

