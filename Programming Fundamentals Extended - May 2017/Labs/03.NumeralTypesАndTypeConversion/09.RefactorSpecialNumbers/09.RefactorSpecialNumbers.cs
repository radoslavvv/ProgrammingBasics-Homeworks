using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());

        for (int i = 1; i <= count; i++)
        {
            bool isSpecial = false;
            int digitsSum = 0;

            int currentNumber = i;
            while (currentNumber > 0)
            {
                digitsSum += currentNumber % 10;
                currentNumber = currentNumber / 10;
            }
            isSpecial = (digitsSum == 5) || (digitsSum == 7) || (digitsSum == 11);
            Console.WriteLine($"{i} -> {isSpecial}");
        }
    }
}


