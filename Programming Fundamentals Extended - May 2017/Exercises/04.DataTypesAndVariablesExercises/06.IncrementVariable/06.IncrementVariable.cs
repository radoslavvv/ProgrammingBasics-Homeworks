using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int byteValue = 0;
        int overflowCount = 0;

        for (int i = 0; i < n; i++)
        {
            byteValue++;
            if (byteValue == 256)
            {
                byteValue = 0;
                overflowCount++;
            }
        }
        if (overflowCount == 0)
        {
            Console.WriteLine(byteValue);
        }
        else
        {
            Console.WriteLine(byteValue);
            Console.WriteLine($"Overflowed {overflowCount} times");
        }
        
    }
}

