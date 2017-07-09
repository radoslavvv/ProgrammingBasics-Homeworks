using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string key = Console.ReadLine();
        string value = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());

        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

        for (int i = 0; i < n; i++)
        {
            List<string> currentLine = Console.ReadLine()
                .Split(new string[] { " => " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string currentKey = currentLine[0];
            List<string> values = currentLine[1]
                .Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            if (!dict.ContainsKey(currentKey))
            {
                dict.Add(currentKey, new List<string>());
            }
            dict[currentKey].AddRange(values);
        }

        foreach (var entry in dict)
        {
            if (entry.Key.Contains(key))
            {
                Console.WriteLine($"{entry.Key}:");
                foreach (var values in entry.Value)
                {
                    if (values.Contains(value))
                    {
                        Console.WriteLine($"-{values}");
                    }
                }
            }
        }
    }

}


