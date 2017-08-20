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
        Regex regex = new Regex(@"\b(?<day>[0-9]{2})(\.|\-|\/)(?<month>[A-Z][a-z]{2})\1(?<year>[0-9]{4})\b");

        string input = Console.ReadLine();

        MatchCollection matches = regex.Matches(input);

        foreach (Match match in matches)
        {
            Console.WriteLine($"Day: {match.Groups["day"]}, Month: {match.Groups["month"]}, Year: {match.Groups["year"]}");
        }
    }
}

