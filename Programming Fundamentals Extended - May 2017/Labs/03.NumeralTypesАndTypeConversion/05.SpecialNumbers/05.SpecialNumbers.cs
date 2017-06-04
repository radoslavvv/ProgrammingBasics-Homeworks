using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int numbersCount = int.Parse(Console.ReadLine());

        for (int i = 1; i <= numbersCount; i++)
        {
            int currentNumber = i;
            int digitsSum = 0;
            bool isSpecial = false;

            while (currentNumber > 0)
            {
                int lastDigit = currentNumber % 10;
                digitsSum += lastDigit;
                currentNumber /= 10;
            }
            isSpecial = digitsSum == 5 || digitsSum == 7 || digitsSum == 11;
            Console.WriteLine($"{i} -> {isSpecial}");
        }
    }
}

