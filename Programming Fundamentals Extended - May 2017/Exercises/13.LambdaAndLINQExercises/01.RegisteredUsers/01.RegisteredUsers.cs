using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Dictionary<string, DateTime> registry = new Dictionary<string, DateTime>();

        string command = Console.ReadLine();

        while (command != "end")
        {
            string name = command.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries)[0];
            DateTime date = DateTime.ParseExact(command.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries)[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);

            registry[name] = date;
            command = Console.ReadLine();
        }

        foreach (var user in registry.Reverse().OrderBy(v => v.Value).Take(5).Reverse().OrderBy(v => v.Value).Reverse())
        {
            Console.WriteLine($"{user.Key}");
        }
    }
}

