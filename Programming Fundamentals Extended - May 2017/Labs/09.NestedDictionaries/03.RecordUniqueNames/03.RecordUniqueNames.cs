using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int linesCount = int.Parse(Console.ReadLine());

        HashSet<string> names = new HashSet<string>();

        for (int i = 0; i < linesCount; i++)
        {
            names.Add(Console.ReadLine());
        }

        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }
}

