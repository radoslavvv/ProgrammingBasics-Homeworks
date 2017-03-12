using System;

namespace BikeRace
{
    class BikeRace
    {
        static void Main()
        {
            int youngBikersCount = int.Parse(Console.ReadLine());
            int elderBikersCount = int.Parse(Console.ReadLine());
            string traceType = Console.ReadLine();

            double totalPrice = 0;


            if(traceType == "trail")
            {
                totalPrice += youngBikersCount * 5.50;
                totalPrice += elderBikersCount * 7;
            }
            else if(traceType == "cross-country")
            {
                totalPrice += youngBikersCount * 8;
                totalPrice += elderBikersCount * 9.50;
                if(youngBikersCount + elderBikersCount >= 50)
                {
                    totalPrice -= totalPrice * 0.25;
                }
            }
            else if (traceType == "downhill")
            {
                totalPrice += youngBikersCount * 12.25;
                totalPrice += elderBikersCount * 13.75;
            }
            else if (traceType == "road")
            {
                totalPrice += youngBikersCount * 20;
                totalPrice += elderBikersCount * 21.50;
            }

            totalPrice -= totalPrice * 0.05;

            Console.WriteLine("{0:0.00}",totalPrice);
        }
    }
}
