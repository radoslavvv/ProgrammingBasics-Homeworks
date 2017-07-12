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
            .Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '\\', '\"', '\'', '/', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(w => w.ToLower())
            .Where(w => w.Length < 5)
            .OrderBy(w => w)
            .Distinct()
            .ToList();

        Console.WriteLine(string.Join(", ", words));
    }
}

