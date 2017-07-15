using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Dictionary<string, string> values = new Dictionary<string, string>();

        string command = Console.ReadLine();
        while (command != "end")
        {
            string[] split = command.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

            values[split[0]] = split[1];
            command = Console.ReadLine();
        }
        string defaultValue = Console.ReadLine();

        foreach (var entry in values.Where(v => v.Value != "null").OrderByDescending(v => v.Value.Length))
        {
            Console.WriteLine($"{entry.Key} <-> {entry.Value}");
        }

        foreach (var entry in values.Where(v => v.Value == "null"))
        {
            Console.WriteLine($"{entry.Key} <-> {defaultValue}");
        }
    }
}

