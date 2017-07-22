using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
        string command = Console.ReadLine();

        while (command != "exit")
        {
            string[] split = command
                .Split(new char[] { '.', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

            int value = 0;
            if (int.TryParse(split[0], out value))
            {
                if (dict.Count != 0)
                {
                    PrintMethods(dict, value);
                }
            }
            else if (split.Length == 1 && dict.ContainsKey(split[0]))
            {
                PrintCollections(dict, split);
            }
            else
            {
                Add(dict, split);
            }

            command = Console.ReadLine();
        }
        string last = Console.ReadLine();
        PrintResults(dict, last);
    }

    private static void PrintMethods(Dictionary<string, List<string>> dict, int value)
    {
        List<string> collection = dict
            .OrderByDescending(d => d.Value.Count)
            .First()
            .Value.OrderBy(v => v.Length)
            .Take(value)
            .ToList();

        foreach (var method in collection)
        {
            Console.WriteLine($"* {method}");
        }
    }

    private static void PrintCollections(Dictionary<string, List<string>> dict, string[] split)
    {
        foreach (var method in dict[split[0]].OrderByDescending(m => m.Length).ThenByDescending(m => m.ToCharArray().Distinct().Count()))
        {
            Console.WriteLine($"* {method}");
        }
    }

    private static void Add(Dictionary<string, List<string>> dict, string[] split)
    {
        string collection = split[0];
        List<string> methods = split
            .Skip(1)
            .Distinct()
            .ToList();

        if (!dict.ContainsKey(collection))
        {
            dict.Add(collection, new List<string>());
        }

        dict[collection].AddRange(methods);
        dict[collection] = dict[collection].Distinct().ToList();
    }

    private static void PrintResults(Dictionary<string, List<string>> dict, string last)
    {
        Dictionary<string, List<string>> result = dict
                    .Where(d => d.Value.Contains(last.Split()[0]))
                    .ToDictionary(x => x.Key, x => x.Value.Distinct().ToList());

        if (last.Split()[1] == "collection")
        {
            foreach (var colection in result.OrderByDescending(c => c.Value.Count).ThenByDescending(c => c.Value.Min(m => m.Length)))
            {
                Console.WriteLine($"{colection.Key}");
            }
        }
        else
        {
            foreach (var colection in result.OrderByDescending(c => c.Value.Count).ThenByDescending(c => c.Value.Min(m => m.Length)))
            {
                Console.WriteLine($"{colection.Key}");
                foreach (var method in colection.Value.OrderByDescending(m => m.Length))
                {
                    Console.WriteLine($"* {method}");
                }
            }
        }
    }
}

