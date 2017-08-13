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
        string tokens = Console.ReadLine();
        char character = tokens[0];
        int characterCount = int.Parse(tokens[1].ToString());

        string input = Console.ReadLine();
        Regex sentenceRegex = new Regex(@"(?<=^)[A-Z].+[\.\?\!](?=$)");
        Regex wordsRegex = new Regex(@"\w+");
        Regex characterRegex = new Regex($"{character}");

        List<string> results = new List<string>();

        while (input != "end")
        {
            if (sentenceRegex.IsMatch(input))
            {
                MatchCollection matches = wordsRegex.Matches(input);

                string[] words = matches.Cast<Match>()
                    .Select(w => w.Value.Trim())
                    .ToArray();

                foreach (var word in words)
                {
                    MatchCollection characterMatch = characterRegex.Matches(word);

                    if (characterMatch.Count >= characterCount)
                    {
                        results.Add(word);
                    }
                }
            }

            input = Console.ReadLine();
        }

        Console.WriteLine($"{string.Join(", ",results)}");
    }
}

