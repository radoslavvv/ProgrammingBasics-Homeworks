using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int product = GetEvensAndOddsProduct(Math.Abs(number));
        Console.WriteLine(product);
    }

    static int GetEvensAndOddsProduct(int number)
    {
        int evensSum = 0;
        int oddsSum = 0;

        while (number > 0)
        {
            int lastDigit = number % 10;

            if (lastDigit % 2 == 0)
            {
                evensSum += lastDigit;
            }
            else if(lastDigit % 2 != 0)
            {
                oddsSum += lastDigit;
            }
            number /= 10;
        }
        return evensSum * oddsSum;
    }
}

