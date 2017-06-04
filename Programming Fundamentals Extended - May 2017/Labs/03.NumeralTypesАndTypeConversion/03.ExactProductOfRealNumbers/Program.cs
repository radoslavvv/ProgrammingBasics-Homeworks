using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int numbersCount = int.Parse(Console.ReadLine());
        decimal product = 1;

        for (int i = 0; i < numbersCount; i++)
        {
            decimal currentNumber = decimal.Parse(Console.ReadLine());
            product *= currentNumber;
        }

        Console.WriteLine(product);
    }
}

