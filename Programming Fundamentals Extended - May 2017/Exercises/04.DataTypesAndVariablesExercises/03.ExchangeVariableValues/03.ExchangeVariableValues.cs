using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        int temp = a;
        a = b;
        b = temp;

        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}

