using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            int peopleCount = int.Parse(Console.ReadLine());

            decimal ticketPrice;
            decimal totalTicketsPrice;
            if (type == "VIP")
            {
                ticketPrice = 499.99m;
            }
            else
            {
                ticketPrice = 249.99m;
            }

            if(peopleCount>=1 && peopleCount <= 4)
            {
                budget -= (0.75m * budget);
            }
            else if(peopleCount >= 5 && peopleCount <= 9)
            {
                budget -= (0.60m * budget);
            }
            else if (peopleCount >= 10 && peopleCount <= 24)
            {
                budget -= (0.50m * budget);
            }
            else if (peopleCount >= 25 && peopleCount <= 49)
            {
                budget -= (0.40m * budget);
            }
            else if (peopleCount >= 50)
            {
                budget -= (0.25m * budget);
            }

            totalTicketsPrice = peopleCount * ticketPrice;

            if (budget >= totalTicketsPrice)
            {
                Console.WriteLine("Yes! You have {0:0.00} leva left.", budget - totalTicketsPrice);

            }
            else if (budget < totalTicketsPrice)
            {
                Console.WriteLine("Not enough money! You need {0:0.00} leva.", totalTicketsPrice - budget);
            }
        }
    }
}
