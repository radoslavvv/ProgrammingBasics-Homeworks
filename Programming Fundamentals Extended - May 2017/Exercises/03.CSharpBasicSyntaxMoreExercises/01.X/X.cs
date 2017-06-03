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

        int insideSpace = n - 2;
        int outsideSpace = 0;
        for (int i = 0; i < n/2; i++)
        {
            Console.WriteLine($"{new string(' ',outsideSpace)}x{new string(' ', insideSpace)}x{new string(' ',outsideSpace)}");
            insideSpace -= 2;
            outsideSpace++;
        }
        Console.WriteLine($"{new string(' ',outsideSpace)}x{new string(' ',outsideSpace)}");
        insideSpace += 2;
        outsideSpace--;
        for (int i = 0; i < n/2; i++)
        {
            Console.WriteLine($"{new string(' ', outsideSpace)}x{new string(' ', insideSpace)}x{new string(' ', outsideSpace)}");
            insideSpace += 2;
            outsideSpace--;
        }
    }
}

