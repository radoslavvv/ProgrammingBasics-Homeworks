using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Dictionary<string,List<int>> dict = new Dictionary<string, List<int>>();

        string input = Console.ReadLine();

        while (input != "end")
        {
            List<string> split = input.Split(new string[] {" -> "}, StringSplitOptions.RemoveEmptyEntries).ToList();
            string key = split[0];

            if (input.Split(',').Length == 1)
            {
                string secondKey = split[1];

                int value = 0;
                if (int.TryParse(secondKey, out value))
                {
                    if (!dict.ContainsKey(key))
                    {
                        dict.Add(key, new List<int>());
                    }
                    dict[key].Add(value);
                }
                else if (dict.ContainsKey(secondKey))
                {
                    dict[key] = dict[secondKey].ToList();
                }
            }
            else
            {
                List < int > values = split[1]
                    .Split(',')
                    .Select(int.Parse)
                    .ToList();

                if (!dict.ContainsKey(key))
                {
                    dict.Add(key,new List<int>());
                }
                dict[key].AddRange(values);
            }
            input = Console.ReadLine();
        }

        foreach (var pair in dict)
        {
            Console.WriteLine($"{pair.Key} === {string.Join(", ",pair.Value)}");
        }
    }
}

