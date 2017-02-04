using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());
            int rightPartSum = 0;
            int leftPartSum = 0;
             
            for (int i = 0; i < numbersCount * 2; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (i < numbersCount)
                {
                    rightPartSum += currentNumber;
                }
                else
                {
                    leftPartSum += currentNumber;
                }
                
            }

            int difference = Math.Abs(leftPartSum - rightPartSum);

            if (difference == 0)
            {
                Console.WriteLine("Yes, sum = {0}",rightPartSum);
            }
            else
            {
                Console.WriteLine("No, diff = {0}",difference);
            }
        }

    }
}
