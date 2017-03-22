using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Divison
{
    class Program
    {
        static void Main(string[] args)
        {
            double numbersCount = double.Parse(Console.ReadLine());

            int divisibleByTwoCount = 0;
            int divisibleByThreeCount = 0;
            int divisibleByFourCount = 0;

            for (int i = 0; i < numbersCount; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber % 2 == 0) divisibleByTwoCount++;
                if (currentNumber % 3 == 0) divisibleByThreeCount++;
                if (currentNumber % 4 == 0) divisibleByFourCount++;
            }
            double divisibleByTwo = (divisibleByTwoCount / numbersCount) * 100;
            double divisibleByThree = (divisibleByThreeCount / numbersCount) * 100;
            double divisibleByFour = (divisibleByFourCount / numbersCount) * 100;

            Console.WriteLine("{0:0.00}%", divisibleByTwo);
            Console.WriteLine("{0:0.00}%", divisibleByThree);
            Console.WriteLine("{0:0.00}%", divisibleByFour);
        }
    }
}
