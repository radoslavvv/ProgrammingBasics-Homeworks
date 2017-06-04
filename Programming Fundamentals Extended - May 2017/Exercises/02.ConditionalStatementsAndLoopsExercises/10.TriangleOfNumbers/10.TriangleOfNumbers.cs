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

        for (int i = 1; i <= number; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}

