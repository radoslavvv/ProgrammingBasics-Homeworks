using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CottageScraper
{
    static void Main()
    {
        Dictionary<string, List<int>> trees = new Dictionary<string, List<int>>();

        string command = Console.ReadLine();
        while (command != "chop chop")
        {
            string[] split = command.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            string type = split[0];
            int height = int.Parse(split[1]);

            if (!trees.ContainsKey(type))
            {
                trees.Add(type, new List<int>());
            }
            trees[type].Add(height);
            command = Console.ReadLine();
        }
        string treeType = Console.ReadLine();
        int minLengthByTree = int.Parse(Console.ReadLine());

        decimal sum = 0;
        decimal count = 0;

        foreach (var tree in trees)
        {
            foreach (var type in tree.Value)
            {
                sum += type;
                count++;
            }
        }
        decimal pricePerMeter = Math.Round(sum / count, 2);

        Dictionary<string, List<int>> usedLogs = trees
            .Where(t => t.Key == treeType)
            .ToDictionary(x => x.Key, x => x.Value);

        List<int> used = usedLogs[treeType]
            .Where(l => l >= minLengthByTree)
            .ToList();

        List<int> unused = usedLogs[treeType]
            .Where(l => l < minLengthByTree)
            .ToList();

        foreach (var type in trees)
        {
            if (type.Key != treeType)
            {
                foreach (var tree in type.Value)
                {
                    unused.Add(tree);
                }
            }
        }

        decimal usedLogsPrice = Math.Round(used.Sum() * pricePerMeter, 2);
        decimal unusedLogsPrice = Math.Round(unused.Sum() * pricePerMeter * 0.25m, 2);
        decimal cottageScraperTotal = Math.Round(unusedLogsPrice + usedLogsPrice, 2);

        Console.WriteLine($"Price per meter: ${pricePerMeter:0.00}");
        Console.WriteLine($"Used logs price: ${usedLogsPrice:0.00}");
        Console.WriteLine($"Unused logs price: ${unusedLogsPrice:0.00}");
        Console.WriteLine($"CottageScraper subtotal: ${cottageScraperTotal:0.00}");
    }
}

