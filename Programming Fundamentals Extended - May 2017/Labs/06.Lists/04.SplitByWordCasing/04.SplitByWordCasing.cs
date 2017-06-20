using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        List<string> words = Console.ReadLine()
            .Split(new char[]
            {':', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' '}, StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        List<string> lowerCase = new List<string>();
        List<string> upperCase = new List<string>();
        List<string> mixedCase = new List<string>();

        foreach (var word in words)
        {
            if (word.All(l => l >= 65 && l <= 90))
            {
                upperCase.Add(word);
            }
            else if (word.All(l => l >= 97 && l <= 122))
            {
                lowerCase.Add(word);
            }
            else
            {
                mixedCase.Add(word);
            }
        }

        Console.WriteLine($"Lower-case: {string.Join(", ", lowerCase)}");
        Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCase)}");
        Console.WriteLine($"Upper-case: {string.Join(", ", upperCase)}");
    }

}
