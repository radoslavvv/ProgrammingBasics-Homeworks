using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal hCount = decimal.Parse(Console.ReadLine());
            decimal rCount = decimal.Parse(Console.ReadLine());
            decimal lCount = decimal.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            char holiday = char.Parse(Console.ReadLine());

            decimal price = 0;

            decimal count = hCount + rCount + lCount;


            if (season == "Summer" || season == "Spring")
            {

                price = (hCount * 2.00m) + (rCount * 4.10m) + (lCount * 2.50m);

                if(holiday == 'Y')
                {
                    price += price * 0.15m;
                }

                if(season == "Spring" && lCount > 7)
                {
                    price -= price * 0.05m;
                }

            }
            else if(season == "Autumn" || season == "Winter")
            {
                price = (hCount * 3.75m) + (rCount * 4.50m) + (lCount * 4.15m);

                if (holiday == 'Y')
                {
                    price += price * 0.15m;
                }

                if(season == "Winter" && rCount >= 10)
                {
                    price -= price * 0.10m;
                }

            }
            if(count > 20)
            {
                price -= price * 0.20m;
            }

            price += 2;
            Console.WriteLine("{0:0.00}",price);
        }
    }
}
