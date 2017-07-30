using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string text = Console.ReadLine();
        string[] tokens = Console.ReadLine().Split();

        string letter = tokens[0];
        int letterIndex = int.Parse(tokens[1]);

        int index = text.IndexOf(letter);
        int count = 0;

        bool found = false;

        while (index != -1)
        {
            count++;
            if (count == letterIndex)
            {
                found = true;
                break;
            }
            index = text.IndexOf(letter, index + 1);
        }

        PrintResult(index, found);
    }

    private static void PrintResult(int index, bool found)
    {
        if (!found)
        {
            Console.WriteLine($"Find the letter yourself!");
        }
        else
        {
            Console.WriteLine(index);
        }
    }
}

