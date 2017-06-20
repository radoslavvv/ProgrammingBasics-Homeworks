using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        List<string> banned = Console.ReadLine()
            .Split()
            .ToList();

        List<string> tracks = new List<string>();


        string command = Console.ReadLine();

        while (command != "end")
        {
            bool isBanned = false;
            for (int i = 0; i < banned.Count; i++)
            {
                if (command.Contains(banned[i]))
                {
                    isBanned = true;
                }
            }
            if (!isBanned)
            {
                tracks.Add(command);
            }
            command = Console.ReadLine();
        }

        foreach (var track in tracks.OrderBy(a => a))
        {
            Console.WriteLine(track);
        }
    }
}

