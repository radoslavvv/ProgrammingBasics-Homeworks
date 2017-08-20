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
        Regex regex = new Regex(@"((^|(?<=\s))-?[0-9]+(\.[0-9]+)?)($|(?=\s))");

        string input = Console.ReadLine();
        MatchCollection matches = regex.Matches(input);

        string[] numbers = matches.Cast<Match>()
            .Select(m => m.Value.Trim())
            .ToArray();


        Console.WriteLine($"{string.Join(" ",numbers)}");
    }
}

