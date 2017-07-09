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

        Dictionary<string, Dictionary<string, int>> cities = new Dictionary<string, Dictionary<string, int>>();

        while (input != "ready")
        {
            string city = input.Split(':')[0];
            List<string> transportValues = input.Split(':')[1].Split(',').ToList();

            foreach (var transportType in transportValues)
            {
                string transport = transportType.Split('-')[0];
                int capacity = int.Parse(transportType.Split('-')[1]);

                if (!cities.ContainsKey(city))
                {
                    cities.Add(city, new Dictionary<string, int>());
                }
                if (!cities[city].ContainsKey(transport))
                {
                    cities[city].Add(transport, 0);
                }
                cities[city][transport] = capacity;
            }
            input = Console.ReadLine();
        }

        input = Console.ReadLine();
        while (input != "travel time!")
        {
            string city = input.Split()[0];
            int seatsCount = int.Parse(input.Split()[1]);

            int totalSeats = cities[city].Values.Sum();

            if (seatsCount <= totalSeats)
            {
                Console.WriteLine($"{city} -> all {seatsCount} accommodated");
            }
            else
            {
                Console.WriteLine($"{city} -> all except {Math.Abs(seatsCount - totalSeats)} accommodated");
            }
            input = Console.ReadLine();
        }
    }
}

