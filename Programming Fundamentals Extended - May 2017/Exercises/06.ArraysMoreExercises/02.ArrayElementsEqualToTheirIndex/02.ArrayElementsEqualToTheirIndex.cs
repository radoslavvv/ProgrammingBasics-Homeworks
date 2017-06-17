using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int[] array = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == i)
            {
                Console.Write($"{array[i]} ");
            }
        }
        Console.WriteLine();
    }
}

