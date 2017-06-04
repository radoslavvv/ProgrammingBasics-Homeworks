using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        double balance = double.Parse(Console.ReadLine());

        string command = Console.ReadLine();
        double price = 0;
        double totalPrice = 0;
        bool ranOutOfMoney = false;

        while (command != "Game Time")
        {
            bool notFound = false;

            switch (command)
            {
                case "OutFall 4":
                    price = 39.99;
                    break;
                case "CS: OG":
                    price = 15.99;
                    break;
                case "Zplinter Zell":
                    price = 19.99;
                    break;
                case "Honored 2":
                    price = 59.99;
                    break;
                case "RoverWatch":
                    price = 29.99;
                    break;
                case "RoverWatch Origins Edition":
                    price = 39.99;
                    break;
                default:
                    Console.WriteLine("Not Found");
                    notFound = true;
                    break;
            }

            if (!notFound)
            {
                if (balance < price)
                {
                    Console.WriteLine("Too Expensive");
                }
                else
                {
                    balance -= price;
                    Console.WriteLine($"Bought {command}");

                    if (balance <= 0)
                    {
                        Console.WriteLine("Out of money!");
                        ranOutOfMoney = true;
                        break;
                    }
                    totalPrice += price;
                }           
            }
            command = Console.ReadLine();
        }
            
        if (!ranOutOfMoney)
        {
            Console.WriteLine($"Total spent: ${totalPrice:0.00}. Remaining: ${balance:0.00}");
        }    
    }
}

