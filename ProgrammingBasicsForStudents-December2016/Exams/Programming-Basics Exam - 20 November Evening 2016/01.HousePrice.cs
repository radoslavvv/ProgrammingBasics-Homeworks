using System;

namespace HousePrice
{
    class HousePrice
    {
        static void Main()
        {
            double smallestRoom = double.Parse(Console.ReadLine());
            double kitchen = double.Parse(Console.ReadLine());
            double squareMeterPrice = double.Parse(Console.ReadLine());


            double bathroom = smallestRoom * 0.50;
            double secondRoom = smallestRoom + (smallestRoom * 0.10);
            double thirdRoom = secondRoom + (secondRoom * 0.10);

            double total = smallestRoom + kitchen + bathroom + secondRoom + +thirdRoom;
            total += total * 0.05;
            total *= squareMeterPrice;

            Console.WriteLine("{0:0.00}",total);


        }
    }
}
