using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int[] numbers = new int[3];

        for (int i = 0; i < 3; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(numbers.Min());
    }
}

