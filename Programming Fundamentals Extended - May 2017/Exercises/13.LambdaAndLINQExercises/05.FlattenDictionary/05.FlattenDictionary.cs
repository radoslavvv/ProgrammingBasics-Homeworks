using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Dictionary<string, Dictionary<string, string>> normal = new Dictionary<string, Dictionary<string, string>>();
        var flatten = new Dictionary<string, Dictionary<string, string>>();

        string command = Console.ReadLine();
        while (command != "end")
        {
            string[] split = command.Split();
            if (split[0] == "flatten")
            {
                string flattenKey = split[1];
                foreach (var entry in normal)
                {
                    if (entry.Key == flattenKey)
                    {
                        List<string> toBeRemoved = new List<string>();
                        foreach (var value in entry.Value)
                        {
                            if (value.Value != "flattened")
                            {
                                if (!flatten.ContainsKey(entry.Key))
                                {
                                    flatten.Add(entry.Key, new Dictionary<string, string>());
                                }
                                if (!flatten[entry.Key].ContainsKey(value.Key))
                                {
                                    flatten[entry.Key].Add(value.Key + normal[entry.Key][value.Key], "flattened");
                                }
                                toBeRemoved.Add(value.Key);
                            }
                        }

                        foreach (string t in toBeRemoved)
                        {
                            normal[entry.Key].Remove(t);
                        }
                    }
                }
            }
            else
            {
                string key = split[0];
                string innerKey = split[1];
                string innerValue = split[2];

                if (!normal.ContainsKey(key))
                {
                    normal.Add(key, new Dictionary<string, string>());
                }

                normal[key][innerKey] = innerValue;
            }
            command = Console.ReadLine();
        }

        foreach (var key in normal.OrderByDescending(k => k.Key.Length))
        {
            Console.WriteLine($"{key.Key}");
            int index = 1;
            foreach (var innerKey in key.Value.OrderBy(i => i.Key.Length))
            {
                Console.WriteLine($"{index}. {innerKey.Key} - {innerKey.Value}");
                index++;
            }
            foreach (var entry in flatten)
            {
                if (entry.Key == key.Key)
                {
                    foreach (var innerKey in flatten[entry.Key])
                    {
                        Console.WriteLine($"{index}. {innerKey.Key}");
                        index++;
                    }
                }
            }
        }
    }
}

