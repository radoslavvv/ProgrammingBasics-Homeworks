using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        List<string> input = Console.ReadLine()
            .Split()
            .ToList();

        for (int i = 0; i < input.Count; i++)
        {
            if (i + 1 % 2 != 0)
            {
                input.RemoveAt(i);
            }
        }
        Console.WriteLine(string.Join("",input));
    }
}

