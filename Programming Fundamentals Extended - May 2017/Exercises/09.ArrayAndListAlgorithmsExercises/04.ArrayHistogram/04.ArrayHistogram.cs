using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        List<string> list = Console.ReadLine()
            .Split()
            .ToList();

        List<string> words = new List<string>();
        List<int> occurences = new List<int>();

        for (int i = 0; i < list.Count; i++)
        {
            string currentWord = list[i];

            if (!words.Contains(currentWord))
            {
                words.Add(currentWord);
                occurences.Add(1);
            }
            else
            {
                for (int j = 0; j < words.Count; j++)
                {
                    if (words[j] == currentWord)
                    {
                        occurences[j]++;
                    }
                }
            }
        }

        for (int i = 1; i < occurences.Count; i++)
        {
            int currentElement = occurences[i];
            string currentString = words[i];
            int key = i - 1;

            while (key >= 0 && currentElement > occurences[key])
            {
                occurences[key + 1] = occurences[key];
                words[key + 1] = words[key];
                key--;
            }
            occurences[key + 1] = currentElement;
            words[key + 1] = currentString;
        }
        double totalCount = occurences.Sum();

        for (int i = 0; i < words.Count; i++)
        {
            Console.WriteLine($"{words[i]} -> {occurences[i]} times ({(occurences[i] / totalCount )* 100:0.00}%)");
        }
    }
}

