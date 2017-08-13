using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Regex regex = new Regex(@"(?<=^)(?<product>[A-Z][a-z]+):(?<price>\d{1,2}\.\d{2})(?=$)");

        string input = Console.ReadLine();
        Dictionary<string,decimal> products = new Dictionary<string, decimal>();
        while (input != "bill")
        {
            Match match = regex.Match(input);
            if (match.Success)
            {
                string product = match.Groups["product"].Value;
                decimal price = decimal.Parse(match.Groups["price"].Value);

                products[product] = price;
            }
            
            input = Console.ReadLine();
        }
        foreach (var product in products.OrderByDescending(p=>p.Value))
        {
            Console.WriteLine($"{product.Key} costs {product.Value:0.00}");
        }
    }
}

