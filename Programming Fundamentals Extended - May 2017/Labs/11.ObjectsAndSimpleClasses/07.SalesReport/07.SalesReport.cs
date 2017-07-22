using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Sale
{
    public string Town { get; set; }
    public string Product { get; set; }
    public decimal Price { get; set; }
    public decimal Quantity { get; set; }
}

class Program
{
    static void Main()
    {
        int salesCount = int.Parse(Console.ReadLine());
        Dictionary<string,decimal> result = new Dictionary<string, decimal>();

        List<Sale> sales = new List<Sale>();

        for (int index = 0; index < salesCount; index++)
        {
            string[] input = Console.ReadLine().Split();

            string city = input[0];
            string product = input[1];
            decimal price = decimal.Parse(input[2]);
            decimal quantity = decimal.Parse(input[3]);

            Sale sale = new Sale()
            {
                Town = city,
                Price = price,
                Product = product,
                Quantity = quantity
            };
            sales.Add(sale);
        }
        foreach (Sale sale in sales)
        {
            if (!result.ContainsKey(sale.Town))
            {
                result.Add(sale.Town, 0);
            }
            result[sale.Town] += sale.Price * sale.Quantity;
        }

        foreach (var town in result.OrderBy(t=>t.Key))
        {
            Console.WriteLine($"{town.Key} -> {town.Value:0.00}");
        }
    }
}

