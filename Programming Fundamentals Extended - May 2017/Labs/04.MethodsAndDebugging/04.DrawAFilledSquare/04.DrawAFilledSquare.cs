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

        PrintFilledSquare(number);
    }

    static void PrintFilledSquare(int number)
    {
        PrintBorder(number);
        PrintBody(number);
        PrintBorder(number);
    }
    static void PrintBorder(int number)
    {
        Console.WriteLine(new string('-',number*2));
    }

    static void PrintBody(int number)
    {
        for (int rows = 0; rows < number  - 2 ; rows++)
        {
            Console.Write("-");
            for (int i = 0; i < number - 1; i++)
            {
                Console.Write(@"\/");
            }
            Console.WriteLine("-");
        }
    }
}

