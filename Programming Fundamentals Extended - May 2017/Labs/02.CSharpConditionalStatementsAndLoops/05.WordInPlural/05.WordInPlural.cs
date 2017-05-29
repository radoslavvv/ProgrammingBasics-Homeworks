using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        if (input.EndsWith("y"))
        {
            input = input.Remove(input.Length - 1, 1);
            input = input.Insert(input.Length, "ies");
        }
        else if (input.EndsWith("o") || input.EndsWith("s") ||
                 input.EndsWith("x") || input.EndsWith("z") || 
                 input.EndsWith("ch")|| input.EndsWith("sh"))
        {
            input = input.Insert(input.Length, "es");
        }
        else
        {
            input = input.Insert(input.Length, "s");
        }
        Console.WriteLine(input);
    }
}

