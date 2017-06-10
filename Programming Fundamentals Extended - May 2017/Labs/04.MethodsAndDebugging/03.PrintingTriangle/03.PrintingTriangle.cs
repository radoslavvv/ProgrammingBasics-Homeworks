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

        PrintTriangle(number);
    }

    static void PrintTriangle(int number)
    {
        for (int row = 1; row <= number; row++)
        {
            for (int digit = 1; digit <= row; digit++)
            {
                Console.Write($"{digit} ");
            }
            Console.WriteLine();
        }
        for (int row = number - 1; row > 0; row--)
        {
            for (int digit = 1; digit <= row; digit++)
            {
                Console.Write($"{digit} ");
            }
            Console.WriteLine();
        }
    }
}

