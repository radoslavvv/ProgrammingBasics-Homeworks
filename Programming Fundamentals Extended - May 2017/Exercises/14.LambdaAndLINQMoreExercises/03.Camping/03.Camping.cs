using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Dictionary<string, Dictionary<string, int>> people = new Dictionary<string, Dictionary<string, int>>();

        string command = Console.ReadLine();

        while (command != "end")
        {
            string[] split = command.Split();
            string name = split[0];
            string camper = split[1];
            int daysCount = int.Parse(split[2]);

            if (!people.ContainsKey(name))
            {
                people.Add(name, new Dictionary<string, int>());
            }
            people[name].Add(camper, daysCount);

            command = Console.ReadLine();
        }

        foreach (var person in people.OrderByDescending(p => p.Value.Count).ThenBy(p => p.Key.Length))
        {
            Console.WriteLine($"{person.Key}: {person.Value.Count}");

            foreach (var camper in person.Value)
            {
                Console.WriteLine($"***{camper.Key}");
            }

            Console.WriteLine($"Total stay: {person.Value.Sum(c => c.Value)} nights");
        }
    }
}

