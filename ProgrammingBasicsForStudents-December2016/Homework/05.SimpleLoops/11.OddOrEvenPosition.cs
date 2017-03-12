using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.OddOrEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            double numbersCount = double.Parse(Console.ReadLine());

            double evenSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;

            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;


            for (int i = 1; i <= numbersCount; i++)
            {
                double currentNumber = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += currentNumber;
                    if (currentNumber > evenMax)
                    {
                        evenMax = currentNumber;
                    }
                    if (currentNumber < evenMin)
                    {
                        evenMin = currentNumber;
                    }
                }
                else if (i % 2 != 0)
                {
                    oddSum += currentNumber;
                    if (currentNumber > oddMax)
                    {
                        oddMax = currentNumber;
                    }
                    if (currentNumber < oddMin)
                    {
                        oddMin = currentNumber;
                    }
                }
            }

            Console.WriteLine("OddSum = {0},", oddSum);
            if (oddMin == int.MaxValue)
            {
                Console.WriteLine("OddMin = No,");
            }
            else
            {
                Console.WriteLine("OddMin = {0},", oddMin);
            }
            if (oddMax == int.MinValue)
            {
                Console.WriteLine("OddMax = No,");
            }
            else
            {
                Console.WriteLine("OddMax = {0},", oddMax);
            }
            Console.WriteLine("EvenSum = {0},", evenSum);

            if (evenMin == int.MaxValue)
            {
                Console.WriteLine("EvenMin = No,");
            }
            else
            {
                Console.WriteLine("EvenMin = {0},", evenMin);
            }

            if (evenMax == int.MinValue)
            {
                Console.WriteLine("EvenMax = No");
            }
            else
            {
                Console.WriteLine("EvenMax = {0}", evenMax);
            }
        }
    }
}
