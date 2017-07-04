using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split().ToArray();
        
        Dictionary<string, int> count = new Dictionary<string, int>();

        for (int i = 0; i < input.Length; i++)
        {
            string currentWord = input[i].ToLower();

            if (!count.ContainsKey(currentWord))
            {
               count.Add(currentWord, 1);
            }
            else
            {
                count[currentWord]++;
            }
        }

        List<string> results = new List<string>();

        foreach (var num in count)
        {
            if(num.Value % 2 != 0)
            {
                results.Add(num.Key);
            }
        }

        Console.WriteLine($"{string.Join(", ",results)}");
    }
}

