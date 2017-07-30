using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Dictionary<string, Dictionary<string, int>> teams = new Dictionary<string, Dictionary<string, int>>();

        string input = Console.ReadLine();
        while (input != "Result")
        {
            string[] tokens = input.Split('|');

            string teamName = "";
            string playerName = "";
            int points = int.Parse(tokens[2]);

            string firstToken = RemoveProhibitedSymbols(tokens[0]);
            string secondToken = RemoveProhibitedSymbols(tokens[1]);

            if (firstToken.ToUpper() == firstToken)
            {
                teamName = firstToken;
                playerName = secondToken;
            }
            else
            {
                playerName = firstToken;
                teamName = secondToken;
            }

            AddTeam(teams, teamName, playerName, points);

            input = Console.ReadLine();
        }

        PrintResults(teams);
    }

    private static string RemoveProhibitedSymbols(string token)
    {
        char[] prohibitedSymbols = new char[] { '@', '$', '%', '*' };

        for (var index = 0; index < prohibitedSymbols.Length; index++)
        {
            var prohibitedSymbol = prohibitedSymbols[index];
            token = token.Replace(prohibitedSymbol.ToString(), "");
        }
        return token;
    }

    private static void AddTeam(Dictionary<string, Dictionary<string, int>> teams, string teamName, string playerName, int points)
    {
        if (!teams.ContainsKey(teamName))
        {
            teams.Add(teamName, new Dictionary<string, int>());
        }
        if (!teams[teamName].ContainsKey(playerName))
        {
            teams[teamName][playerName] = 0;
        }
        teams[teamName][playerName] = points;
    }

    private static void PrintResults(Dictionary<string, Dictionary<string, int>> teams)
    {
        foreach (var team in teams.OrderByDescending(t => t.Value.Values.Sum()))
        {
            Console.WriteLine($"{team.Key} => {team.Value.Values.Sum()}");
            Console.WriteLine($"Most points scored by {team.Value.OrderByDescending(p => p.Value).First().Key}");
        }
    }
}

