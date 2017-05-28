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
        int sum = 0;

        for (int i = 1; i < number * 2; i+=2)
        {
            sum += i;
            Console.WriteLine(i);
        }
        Console.WriteLine($"Sum: {sum}");
    }
}

