using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Regex regex = new Regex(@"\b(?:0x)?[0-9A-F]+\b");
        string input = Console.ReadLine();
        MatchCollection matches = regex.Matches(input);
        string[] matchedInput = matches.Cast<Match>()
            .Select(m => m.Value.Trim())
            .ToArray();

        Console.WriteLine($"{string.Join(" ",matchedInput)}");
    }
}

