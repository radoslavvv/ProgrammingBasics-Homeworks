using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> normalFruitPrices = new Dictionary<string, double> { { "banana", 2.50 }, { "apple", 1.20 }, { "orange", 0.85 }, { "grapefruit", 1.45 }, { "kiwi", 2.70 }, { "pineapple", 5.50 }, { "grapes", 3.85 } };
            Dictionary<string, double> weekendFruitPrices = new Dictionary<string, double> { { "banana", 2.70 }, { "apple", 1.25 }, { "orange", 0.90 }, { "grapefruit", 1.60 }, { "kiwi", 3.0 }, { "pineapple", 5.60 }, { "grapes", 4.20 } };
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Sunday", "Saturday" };

            string fruit = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            if (normalFruitPrices.ContainsKey(fruit) && days.Contains(dayOfWeek))
            {
                if (dayOfWeek.Equals("Saturday") || dayOfWeek.Equals("Sunday"))
                {
                    Console.WriteLine("{0:0.00}", weekendFruitPrices[fruit] * quantity);
                }
                else
                {
                    Console.WriteLine("{0:0.00}", normalFruitPrices[fruit] * quantity);
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}