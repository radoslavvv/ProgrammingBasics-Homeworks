using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MaxNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.MinValue;
            int numbersCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbersCount; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number > maxNumber)
                {
                    maxNumber = number;
                }
            }
            Console.WriteLine(maxNumber);
        }
    }
}
