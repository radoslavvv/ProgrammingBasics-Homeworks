using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        int itemsCount = int.Parse(Console.ReadLine());

        double totalPrice = 0;
        for (int i = 0; i < itemsCount; i++)
        {
            string itemName = Console.ReadLine();
            double itemPrice = double.Parse(Console.ReadLine());
            int itemCount = int.Parse(Console.ReadLine());
            if (itemCount == 1)
            {
                Console.WriteLine($"Adding {itemCount} {itemName} to cart.");
            }
            else
            {
                Console.WriteLine($"Adding {itemCount} {itemName}s to cart.");
            }
            totalPrice += itemCount * itemPrice;
        }
        Console.WriteLine($"Subtotal: ${totalPrice:0.00}");
        if (totalPrice > budget)
        {
            Console.WriteLine($"Not enough. We need ${totalPrice - budget:0.00} more.");
        }
        else
        {
            Console.WriteLine($"Money left: ${budget - totalPrice:0.00}");
        }
    }
}

