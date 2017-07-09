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

        var dict = new Dictionary<string,Dictionary<string,List<string>>>();
        for (int index = 0; index < linesCount; index++)
        {
            string input = Console.ReadLine();
            List<string> tokens = input.Split().ToList();

            string continent = tokens[0];
            string country = tokens[1];
            string city = tokens[2];

            if (!dict.ContainsKey(continent))
            {
                dict.Add(continent,new Dictionary<string, List<string>>());
            }
            if (!dict[continent].ContainsKey(country))
            {
                dict[continent][country]= new List<string>();
            }
            dict[continent][country].Add(city);
        }

        foreach (var continent in dict)
        {
            Console.WriteLine($"{continent.Key}:");
            foreach (var country in continent.Value)
            {
                Console.WriteLine($"  {country.Key} -> {string.Join(", ",country.Value)}");
            }
        }
    }
}

