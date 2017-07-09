using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Dictionary<string,HashSet<int>> shells = new Dictionary<string, HashSet<int>>();

        string command = Console.ReadLine();

        while (command != "Aggregate")
        {
            string city = command.Split()[0];
            int size = int.Parse(command.Split()[1]);

            if (!shells.ContainsKey(city))
            {
                shells.Add(city,new HashSet<int>());
            }
            shells[city].Add(size);

            command = Console.ReadLine();
        }

        foreach (var shell in shells)
        {
            Console.WriteLine($"{shell.Key} -> {string.Join(", ",shell.Value)} ({shell.Value.Sum() - (shell.Value.Sum() / shell.Value.Count)})");
        }
    }
}

