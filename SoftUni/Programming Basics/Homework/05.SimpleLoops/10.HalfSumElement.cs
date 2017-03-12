using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());
           
            int sum = 0;
            int largestNumber = int.MinValue;
            for (int i = 0; i < numbersCount; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                sum += currentNumber;
                if (currentNumber > largestNumber)
                {
                    largestNumber = currentNumber;
                }
            }
            if (largestNumber == sum - largestNumber)
            {
                Console.WriteLine("Yes sum = {0}", largestNumber);
            }
            else
            {
                int diff = Math.Abs((sum - largestNumber) - largestNumber);
                Console.WriteLine("No diff = {0}", diff);
            }
        }
    }
}
