using System;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        MatchCollection matchedNames = Regex.Matches(Console.ReadLine(), @"\b[A-Z][a-z]+ [A-Z][a-z]+\b");

        foreach (Match name in matchedNames)
        {
            Console.Write($"{name.Value} ");
        }
        Console.WriteLine();
    }
}

