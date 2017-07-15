using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string command = Console.ReadLine();
        Dictionary<string, Dictionary<string, int>> teams = new Dictionary<string, Dictionary<string, int>>();

        while (command != "stop the game")
        {
            string[] split = command.Split('|');

            string team = split[1];
            string player = split[0];
            int pointsMade = int.Parse(split[2]);

            if (!teams.ContainsKey(team))
            {
                teams.Add(team, new Dictionary<string, int>());
            }

            if (teams[team].Values.Count < 3)
            {
                teams[team].Add(player, pointsMade);
            }

            command = Console.ReadLine();
        }

        int index = 1;
        foreach (var team in teams.Where(t => t.Value.Values.Count == 3).OrderByDescending(t => t.Value.Values.Sum()))
        {
            Console.WriteLine($"{index}. {team.Key}; Players:");
            foreach (var player in team.Value.OrderByDescending(p=>p.Value))
            {
                Console.WriteLine($"###{player.Key}: {player.Value}");   
            }
            index++;
        }
    }
}

