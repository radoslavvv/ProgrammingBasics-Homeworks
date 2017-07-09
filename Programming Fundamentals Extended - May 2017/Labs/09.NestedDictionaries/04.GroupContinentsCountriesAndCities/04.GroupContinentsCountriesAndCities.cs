using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int linesCount = int.Parse(Console.ReadLine());

        var continents = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();

        for (int i = 0; i < linesCount; i++)
        {
            string input = Console.ReadLine();
            List<string> tokens = input.Split().ToList();

            string continent = tokens[0];
            string country = tokens[1];
            string city = tokens[2];

            if (!continents.ContainsKey(continent))
            {
                continents.Add(continent,new SortedDictionary<string, SortedSet<string>>());
            }
            if (!continents[continent].ContainsKey(country))
            {
                continents[continent][country] = new SortedSet<string>();
            }
            continents[continent][country].Add(city);
        }

        foreach (var continent in continents)
        {
            Console.WriteLine($"{continent.Key}:");
            foreach (var country in continent.Value)
            {
                Console.WriteLine($"  {country.Key} -> {string.Join(", ",country.Value)}");
            }
        }
    }
}

