using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.OddOrEvenSUm
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSum = 0;

            for (int i = 0; i < numbersCount; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (i % 2 != 0)
                {
                    oddSum += currentNumber;
                }
                else if(i%2 == 0)
                {
                    evenSum += currentNumber;
                }
            }
            int difference = Math.Abs(oddSum - evenSum);

            if (difference == 0)
            {
                Console.WriteLine("Yes sum = {0}",oddSum);
            }
            else
            {
                Console.WriteLine("No diff = {0}",difference);
            }
        }
    }
}
