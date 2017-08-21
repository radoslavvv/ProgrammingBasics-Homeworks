using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Dictionary<string, Dictionary<string, long>> trains = new Dictionary<string, Dictionary<string, long>>();

        string input = Console.ReadLine();
        while (input != "It's Training Men!")
        {
            string[] tokens = input
                .Split(new string[] { " ", "-", ":", ">", "=" }, StringSplitOptions.RemoveEmptyEntries);

            if (tokens.Length == 3)
            {
                AddNewTrain(trains, tokens);
            }
            else if (tokens.Length == 2)
            {
                if (input.Split()[1] == "->")
                {
                    AddWagons(trains, tokens);
                }
                else if (input.Split()[1] == "=")
                {
                    CopyWagons(trains, tokens);
                }
            }
            input = Console.ReadLine();
        }
        PrintResult(trains);
    }

    private static void PrintResult(Dictionary<string, Dictionary<string, long>> trains)
    {
        foreach (var train in trains.OrderByDescending(t => t.Value.Values.Sum()).ThenBy(t => t.Value.Values.Count))
        {
            Console.WriteLine($"Train: {train.Key}");
            foreach (var wagon in train.Value.OrderByDescending(w => w.Value))
            {
                Console.WriteLine($"###{wagon.Key} - {wagon.Value}");
            }
        }
    }

    private static void CopyWagons(Dictionary<string, Dictionary<string, long>> trains, string[] tokens)
    {
        string firstTrain = tokens[0];
        string secondTrain = tokens[1];

        if (!trains.ContainsKey(firstTrain))
        {
            trains.Add(firstTrain, new Dictionary<string, long>());
        }
        trains[firstTrain] = trains[secondTrain].ToDictionary(t => t.Key, t => t.Value);
    }

    private static void AddWagons(Dictionary<string, Dictionary<string, long>> trains, string[] tokens)
    {
        string firstTrain = tokens[0];
        string secondTrain = tokens[1];

        if (!trains.ContainsKey(firstTrain))
        {
            trains.Add(firstTrain, new Dictionary<string, long>());
        }
        foreach (var train in trains[secondTrain])
        {
            trains[firstTrain].Add(train.Key, train.Value);
        }
        trains.Remove(secondTrain);
    }

    private static void AddNewTrain(Dictionary<string, Dictionary<string, long>> trains, string[] tokens)
    {
        string trainName = tokens[0];
        string wagonName = tokens[1];
        long power = long.Parse(tokens[2]);

        if (!trains.ContainsKey(trainName))
        {
            trains.Add(trainName, new Dictionary<string, long>());
        }
        trains[trainName].Add(wagonName, power);
    }
}

