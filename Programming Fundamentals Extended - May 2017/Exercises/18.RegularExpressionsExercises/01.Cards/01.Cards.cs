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
        Regex regex = new Regex(@"((?<=[SHDC])|^)((10|[2-9]|[JQKA])[SHDC])");
        string input = Console.ReadLine();

        MatchCollection matches = regex.Matches(input);
        string[] cards = matches.Cast<Match>().Select(m => m.Value.Trim()).ToArray();
        Console.WriteLine($"{string.Join(", ",cards)}");
    }
}

