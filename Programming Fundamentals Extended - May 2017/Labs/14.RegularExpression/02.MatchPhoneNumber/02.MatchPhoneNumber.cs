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
        Regex regex = new Regex(@"\+359(-| )2\1[0-9]{3}\1[0-9]{4}\b");

        string phones = Console.ReadLine();

        MatchCollection matches = regex.Matches(phones);

        string[] matchedPhones = matches
            .Cast<Match>()
            .Select(a => a.Value.Trim())
            .ToArray();

        Console.WriteLine($"{string.Join(", ",matchedPhones)}");
    }
}

