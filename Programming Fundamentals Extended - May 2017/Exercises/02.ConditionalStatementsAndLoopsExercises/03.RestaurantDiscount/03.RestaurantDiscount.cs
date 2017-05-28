using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int groupSize = int.Parse(Console.ReadLine());
        string packageType = Console.ReadLine();
        string room = string.Empty;

        double price = 0;
        if (groupSize <= 120)
        {
            if (groupSize <= 50)
            {
                price = 2500;
                room = "Small Hall";
            }
            else if (groupSize <= 100)
            {
                price = 5000;
                room = "Terrace";
            }
            else if (groupSize <= 120)
            {
                price = 7500;
                room = "Great Hall";
            }

            if (packageType == "Normal")
            {
                price += 500;
                price -= price * 0.05;
            }
            else if (packageType == "Gold")
            {
                price += 750;
                price -= price * 0.10;
            }
            else if (packageType == "Platinum")
            {
                price += 1000;
                price -= price * 0.15;
            }

            double pricePerPerson = price / groupSize;
            Console.WriteLine($"We can offer you the {room}");
            Console.WriteLine($"The price per person is {pricePerPerson:0.00}$");
        } 
        else
        {
            Console.WriteLine("We do not have an appropriate hall.");
        } 
    }
}

