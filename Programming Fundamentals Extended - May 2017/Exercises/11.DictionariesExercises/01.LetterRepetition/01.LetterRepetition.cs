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

        Dictionary<char, int> occ = new Dictionary<char, int>();
        for (int i = 0; i < input.Length; i++)
        {
            if (!occ.ContainsKey(input[i]))
            {
                occ[input[i]] = 0;
            }
            occ[input[i]]++;

        }
        foreach (var letter in occ)
        {
            Console.WriteLine($"{letter.Key} -> {letter.Value}");
        }
    }
}

