using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

class Product
{
    public string Type { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}

class Products
{
    static void Main()
    {
        List<Product> activeProducts = ReadProductsFromDatabase();
        StreamReader reader  = new StreamReader("input.txt");

        string input = reader.ReadLine();
        while (input != "exit")
        {
            string[] tokens = input.Split();

            if (tokens.Length > 1)
            {
                AddProduct(activeProducts, tokens);
            }
            else if (tokens[0] == "stock")
            {
                WriteStock(activeProducts);
            }
            else if (tokens[0] == "analyze")
            {
                WriteAnalization();
            }
            else if (tokens[0] == "sales")
            {
                WriteSales(activeProducts);
            }

            input = reader.ReadLine();
        }
        reader.Close();
    }

    private static void AddProduct(List<Product> activeProducts, string[] tokens)
    {
        string name = tokens[0];
        string type = tokens[1];
        decimal price = decimal.Parse(tokens[2]);
        int quantity = int.Parse(tokens[3]);

        if (activeProducts.Any(p => p.Name == name && p.Type == type))
        {
            activeProducts.Single(p => p.Name == name && p.Type == type).Quantity = quantity;
            activeProducts.Single(p => p.Name == name && p.Type == type).Price = price;
        }
        else
        {
            Product currentProduct = new Product()
            {
                Name = name,
                Type = type,
                Price = price,
                Quantity = quantity
            };

            activeProducts.Add(currentProduct);
        }
    }

    private static List<Product> ReadProductsFromDatabase()
    {
        List<Product> activeProducts = new List<Product>();
        StreamReader activeReader = new StreamReader("products.txt");
        string activeLine = activeReader.ReadLine();
        while (activeLine != null)
        {
            string[] split = activeLine.Split();
            activeProducts.Add(new Product()
            {
                Type = split[0],
                Name = split[1],
                Price = decimal.Parse(split[2]),
                Quantity = int.Parse(split[3])
            });
            activeLine = activeReader.ReadLine();
        }
        activeReader.Close();
        return activeProducts;
    }

    private static void WriteStock(List<Product> activeProducts)
    {
        StreamWriter writer = new StreamWriter("products.txt");
        foreach (var product in activeProducts)
        {
            writer.WriteLine($"{product.Type} {product.Name} {product.Price} {product.Quantity}");
        }
        writer.Close();
    }

    private static void WriteAnalization()
    {
        StreamReader reader = new StreamReader("products.txt");
        StreamWriter writer = new StreamWriter("output.txt", append: true);

        List<Product> productsList = new List<Product>();
        string line = reader.ReadLine();
        while (line != null)
        {
            string[] split = line.Split();


            productsList.Add(new Product()
            {
                Type = split[0],
                Name = split[1],
                Price = decimal.Parse(split[2]),
                Quantity = int.Parse(split[3])
            });

            line = reader.ReadLine();
        }
        reader.Close();
        if (productsList.Any())
        {
            foreach (var product in productsList.OrderBy(p => p.Type))
            {
                writer.WriteLine($"{product.Type}, Product: {product.Name}");
                writer.WriteLine($"Price: ${product.Price}, Amount Left: {product.Quantity}");
            }
        }
        else
        {
            writer.WriteLine($"No products stocked");
        }
        writer.Close();
    }

    private static void WriteSales(List<Product> activeProducts)
    {
        StreamWriter writer = new StreamWriter("output.txt", append: true);
        Dictionary<string, decimal> result = new Dictionary<string, decimal>();
        foreach (var product in activeProducts)
        {
            if (!result.ContainsKey(product.Type))
            {
                result.Add(product.Type, 0);
            }
            result[product.Type] += product.Price * product.Quantity;
        }

        foreach (var type in result.OrderByDescending(t => t.Value).Where(t => t.Value > 0))
        {
            writer.WriteLine($"{type.Key}: ${type.Value:0.00}");
        }

        writer.Close();
    }
}

