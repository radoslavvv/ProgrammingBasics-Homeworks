using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        char[] punctuationSigns = new char[] {' ',',', '.', '!', '?', ';', ':', '-', '/', '\\'};

        while (input != "end")
        {
            string[] words = input.Split(punctuationSigns, StringSplitOptions.RemoveEmptyEntries);

            List<string> capitalizedWords = CapitalizeWords(words);
            Console.WriteLine($"{string.Join(", ", capitalizedWords)}");

            input = Console.ReadLine();
        }
    }

    private static List<string> CapitalizeWords(string[] words)
    {
        List<string> capitalizedWords = new List<string>();

        foreach (var word in words)
        {
            string result = word[0].ToString().ToUpper() + word.Substring(1).ToLower();
            capitalizedWords.Add(result);
        }

        return capitalizedWords;
    }
}

