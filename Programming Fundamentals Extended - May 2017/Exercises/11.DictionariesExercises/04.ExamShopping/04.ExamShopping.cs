using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Dictionary<string,int> items = new Dictionary<string, int>();

        string command = Console.ReadLine();
        while (command != "shopping time")
        {
            string[] split = command.Split();
            string item = split[1];
            int quantity = int.Parse(split[2]);

            if (!items.ContainsKey(item))
            {
                items.Add(item,0);
            }
            items[item] += quantity;

            command = Console.ReadLine();
        }
        command = Console.ReadLine();
        while (command != "exam time")
        {
            string[] split = command.Split();
            string item = split[1];
            int quantity = int.Parse(split[2]);

            if (!items.ContainsKey(item))
            {
                Console.WriteLine($"{item} doesn't exist");
            }
            else if (items[item] <= 0)
            {
                Console.WriteLine($"{item} out of stock");
            }
            else
            {
                items[item] -= quantity;
            }

            command = Console.ReadLine();
        }

        foreach (var item in items)
        {
            if (item.Value > 0)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
