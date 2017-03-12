using System;

namespace FlowerShop
{
    class FlowerShop
    {
        static void Main()
        {
            int magnoliasCount = int.Parse(Console.ReadLine());
            int hyacinthsCount = int.Parse(Console.ReadLine());
            int rosesCount = int.Parse(Console.ReadLine());
            int cactusesCount = int.Parse(Console.ReadLine());
            double presentPrice = double.Parse(Console.ReadLine());

            double magnoliasPrice = magnoliasCount * 3.25;
            double hyacinthsPrice = hyacinthsCount * 4;
            double rosesPrice = rosesCount * 3.50;
            double cactusesPrice = cactusesCount * 8;

            double totalPrice = magnoliasPrice + hyacinthsPrice + rosesPrice + cactusesPrice;
            totalPrice -= totalPrice * 0.05;

            if (totalPrice >= presentPrice)
            {
                Console.WriteLine("She is left with {0} leva.", Math.Floor(totalPrice - presentPrice));
            }
            else
            {
                Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(presentPrice - totalPrice));
            }

        }
    }
}
