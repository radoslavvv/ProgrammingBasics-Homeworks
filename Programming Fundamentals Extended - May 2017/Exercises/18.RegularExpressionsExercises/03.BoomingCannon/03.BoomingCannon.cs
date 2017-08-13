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
        int[] tokens = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
        int distance = tokens[0];
        int count = tokens[1];

        string input = Console.ReadLine();

        Regex regex = new Regex(@"(\\<<<)(.+?((?=\1)|$))");
        MatchCollection matches = regex.Matches(input);

        List<string> words = new List<string>();
        foreach (Match match in matches)
        {
            string text = string.Join("", match.Groups[2].Value.ToCharArray().Skip(distance).Take(count));
            words.Add(text);
        }
        Console.WriteLine($"{string.Join("/\\",words.Where(w=>w!=""))}");
    }
}

