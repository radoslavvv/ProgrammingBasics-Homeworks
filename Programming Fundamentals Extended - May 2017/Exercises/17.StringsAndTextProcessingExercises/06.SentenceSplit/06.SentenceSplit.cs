using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string text = Console.ReadLine();
        string delimiter = Console.ReadLine();

        string[] split = text.Split(new string[]{$"{delimiter}"},StringSplitOptions.None);

        Console.WriteLine($"[{string.Join(", ",split)}]");
    }
}

