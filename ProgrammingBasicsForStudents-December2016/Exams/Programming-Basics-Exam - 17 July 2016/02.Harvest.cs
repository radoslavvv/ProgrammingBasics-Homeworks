using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal x = decimal.Parse(Console.ReadLine());
            decimal y = decimal.Parse(Console.ReadLine());
            decimal z = decimal.Parse(Console.ReadLine());
            decimal workers = decimal.Parse(Console.ReadLine());

            decimal total = x * y;
            decimal wine = (total * 0.40m) / 2.5m;


            if (wine < z)
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(z - wine));

            }
            else if(wine >= z)
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.\n{1} liters left -> {2} liters per person.", Math.Floor(wine), Math.Ceiling(wine - z), Math.Ceiling((wine - z )/ workers));

            }



        }
    }
}
