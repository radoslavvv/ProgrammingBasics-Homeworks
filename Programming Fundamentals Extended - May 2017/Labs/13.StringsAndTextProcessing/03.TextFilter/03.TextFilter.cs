using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string[] words = Console.ReadLine().Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);

        string text = Console.ReadLine();

        foreach (var word in words)
        {
            text = text.Replace(word, new string('*', word.Length));
        }
        Console.WriteLine(text);
    }
}

