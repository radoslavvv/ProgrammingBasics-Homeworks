using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();

        int capitalsCount = 0;

        foreach (var word in input)
        {
            if (word.Length == 1 && char.Parse(word) >= 65 && char.Parse(word)<= 90)
            {
                capitalsCount++;
            }
        }
        Console.WriteLine(capitalsCount);
    }
}

