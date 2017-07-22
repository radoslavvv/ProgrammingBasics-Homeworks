using System;
using System.Collections.Generic;
using System.Linq;

class Sale
{
    public string Town { get; set; }
    public string Product { get; set; }
    public decimal Price { get; set; }
    public decimal Quantity { get; set; }
}

class SalesReport
{
    static void Main()
    {
        int salesCount = int.Parse(Console.ReadLine());

        List<Sale> totalSales = ReadSales(salesCount);
        Dictionary<string, decimal> sales = CalculateSalesByCities(totalSales);

        foreach (var sale in sales)
        {
            Console.WriteLine($"{sale.Key} -> {sale.Value:0.00}");
        }
    }

    private static Dictionary<string, decimal> CalculateSalesByCities(List<Sale> sales)
    {
        Dictionary<string, decimal> result = new Dictionary<string, decimal>();

        foreach (var sale in sales)
        {
            if (!result.ContainsKey(sale.Town))
            {
                result.Add(sale.Town, 0);
            }
            result[sale.Town] += sale.Price * sale.Quantity;
        }
        return result.OrderBy(s => s.Key).ToDictionary(x => x.Key, x => x.Value);
    }

    private static List<Sale> ReadSales(int salesCount)
    {
        List<Sale> sales = new List<Sale>();

        for (int i = 0; i < salesCount; i++)
        {
            string[] line = Console.ReadLine().Split();

            Sale currentSale = new Sale()
            {
                Town = line[0],
                Product = line[1],
                Price = decimal.Parse(line
                    [2]),
                Quantity = decimal.Parse(line[3]),
            };
            sales.Add(currentSale);
        }
        return sales.OrderBy(s => s.Town).ToList();
    }
}