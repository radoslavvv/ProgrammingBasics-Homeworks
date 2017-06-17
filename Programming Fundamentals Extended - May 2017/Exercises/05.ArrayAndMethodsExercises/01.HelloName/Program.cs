using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string name = Console.ReadLine();
        PrintName(name);
    }

    private static void PrintName(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }
}

