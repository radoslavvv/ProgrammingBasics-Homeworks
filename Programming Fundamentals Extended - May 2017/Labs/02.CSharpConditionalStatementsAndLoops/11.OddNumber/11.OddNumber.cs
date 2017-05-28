using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        while (true)
        {
            int number = int.Parse(Console.ReadLine());
            number = Math.Abs(number);

            if (number % 2 != 0)
            {
                Console.WriteLine($"The number is: {number}");
                break;
            }
            else
            {
                Console.WriteLine("Please write an odd number.");
            }
        }
    }
}

