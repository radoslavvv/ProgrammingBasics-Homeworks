using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SquareOfStars
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("*");
        }

        Console.WriteLine();

        for (int b = 0; b < n - 2; b++)
        {
            Console.Write("*");

            for (int a = 0; a < n - 2; a++)
            {
                Console.Write(" ");
            }

            Console.Write("*");

            Console.WriteLine();
        }

        for (int i = 0; i < n; i++)
        {
            Console.Write("*");
        }
    }
}

