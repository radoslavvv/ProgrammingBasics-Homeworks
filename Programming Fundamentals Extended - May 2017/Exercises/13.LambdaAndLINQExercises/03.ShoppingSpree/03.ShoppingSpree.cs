using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        decimal budget = decimal.Parse(Console.ReadLine());

        Dictionary<string, decimal> products = new Dictionary<string, decimal>();

        string command = Console.ReadLine();
        while (command != "end")
        {
            string[] split = command.Split();

            if (!products.ContainsKey(split[0]) || products[split[0]] > decimal.Parse(split[1]))
            {
                products[split[0]] = decimal.Parse(split[1]);
            }

            command = Console.ReadLine();
        }

        if (products.Sum(p => p.Value) > budget)
        {
            Console.WriteLine($"Need more money... Just buy banichka");
        }
        else
        {
            foreach (var product in products.OrderByDescending(p => p.Value).ThenBy(p => p.Key.Length))
            {
                Console.WriteLine($"{product.Key} costs {product.Value:0.00}");
            }
        }
    }
}

