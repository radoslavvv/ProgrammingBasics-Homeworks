using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Dictionary<string, decimal> allProducts = new Dictionary<string, decimal>();

        string input = Console.ReadLine();
        while (input != "Shop is open")
        {
            AddProducts(allProducts, input);

            input = Console.ReadLine();
        }

        Dictionary<string, List<string>> bought = new Dictionary<string, List<string>>();

        input = Console.ReadLine();
        while (input != "Print")
        {
            string[] split = input.Split(new char[] { ',', ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (split[0] == "Discount")
            {
                DiscountProducts(allProducts);
            }
            else
            {
                BuyProduct(bought, split);
            }
            input = Console.ReadLine();
        }

        Dictionary<string, Dictionary<string, decimal>> result = new Dictionary<string, Dictionary<string, decimal>>();
        CalculatePrice(allProducts, bought, result);
        PrintResults(allProducts, result);

    }

    private static void AddProducts(Dictionary<string, decimal> allProducts, string input)
    {
        string product = input.Split()[0];
        decimal price = decimal.Parse(input.Split()[1]);

        allProducts[product] = price;
    }

    private static void CalculatePrice(Dictionary<string, decimal> products, Dictionary<string, List<string>> bought, Dictionary<string, Dictionary<string, decimal>> boughtProducts)
    {
        foreach (var person in bought)
        {
            if (!boughtProducts.ContainsKey(person.Key))
            {
                boughtProducts.Add(person.Key, new Dictionary<string, decimal>());
            }
            foreach (var product in person.Value)
            {
                if (!boughtProducts[person.Key].ContainsKey(product))
                {
                    boughtProducts[person.Key].Add(product, 0);
                }
                boughtProducts[person.Key][product] += products[product];
            }
        }
    }

    private static void PrintResults(Dictionary<string, decimal> products, Dictionary<string, Dictionary<string, decimal>> boughtProducts)
    {
        foreach (var person in boughtProducts.OrderByDescending(p => p.Value.Values.Sum()).Take(1))
        {
            Console.WriteLine($"Biggest spender: {person.Key}");
            Console.WriteLine($"^Products bought:");
            foreach (var product in person.Value)
            {
                Console.WriteLine($"^^^{product.Key}: {products[product.Key]:0.00}");
            }
            Console.WriteLine($"Total: {person.Value.Values.Sum():0.00}");
        }
    }

    private static void BuyProduct(Dictionary<string, List<string>> bought, string[] split)
    {
        string name = split[0];
        if (!bought.ContainsKey(name))
        {
            bought.Add(name, new List<string>());
        }
        foreach (var product in split.Skip(1))
        {
            bought[name].Add(product);
        }
    }

    private static void DiscountProducts(Dictionary<string, decimal> products)
    {
        List<string> mostExpensive = GetMostExpensive(products);
        foreach (string expensive in mostExpensive)
        {
            products[expensive] -= products[expensive] * 0.10m;
        }
    }

    private static List<string> GetMostExpensive(Dictionary<string, decimal> products)
    {
        List<string> mostExpensive = new List<string>();
        foreach (var product in products.OrderByDescending(p => p.Value))
        {
            mostExpensive.Add(product.Key);
            if (mostExpensive.Count == 3)
            {
                break;
            }
        }
        return mostExpensive;
    }
}

