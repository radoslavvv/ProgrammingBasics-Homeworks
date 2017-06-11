using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int oddCount = 0;
        foreach (var number in numbers)
        {
            if (Math.Abs(number) % 2 != 0)
            {
                oddCount++;
            }
        }
        Console.WriteLine(oddCount);
    }
}

