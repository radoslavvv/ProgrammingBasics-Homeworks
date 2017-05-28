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

        int times = int.Parse(Console.ReadLine());

        if (times <= 10)
        {
            for (int i = times; i <= 10; i++)
            {
                Console.WriteLine($"{number} X {i} = {number * i}");
            }
        }
        else if(times > 10)
        {
            Console.WriteLine($"{number} X {times} = {number * times}");
        }
    }
}

