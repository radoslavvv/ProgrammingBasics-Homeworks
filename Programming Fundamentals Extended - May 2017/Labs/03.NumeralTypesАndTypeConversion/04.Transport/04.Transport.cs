using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int peopleCount = int.Parse(Console.ReadLine());

        double totalCapacity = 4 + 8 + 12;
        int courcesCount = (int)Math.Ceiling(peopleCount / totalCapacity);

        Console.WriteLine(courcesCount);
    }
}

