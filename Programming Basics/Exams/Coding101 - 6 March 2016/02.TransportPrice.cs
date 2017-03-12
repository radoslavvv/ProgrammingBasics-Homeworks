using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            double kilometersCount = double.Parse(Console.ReadLine());
            string time = Console.ReadLine();

            double totalPrice = 0;

            if (kilometersCount >= 20 && kilometersCount < 100)
            {
                totalPrice = kilometersCount * 0.09;
            }
            else if (kilometersCount >= 100)
            {
                totalPrice = kilometersCount * 0.06;
            }
            else
            {
                if (time == "day")
                {
                    totalPrice = 0.70 + (kilometersCount * 0.79);
                }
                else if (time == "night")
                {
                    totalPrice = 0.70 + (kilometersCount * 0.90);
                }
            }
            Console.WriteLine(totalPrice);
        }
    }
}
