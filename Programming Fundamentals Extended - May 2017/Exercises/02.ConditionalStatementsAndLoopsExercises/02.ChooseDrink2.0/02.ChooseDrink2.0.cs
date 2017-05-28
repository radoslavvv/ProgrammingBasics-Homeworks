﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string profession = Console.ReadLine();
        int quantity = int.Parse(Console.ReadLine());

        double price = 0;

        switch (profession)
        {
            case "Athlete":
                price = quantity * 0.70;
                break;
            case "Businessman":
            case "Businesswoman":
                price = quantity * 1.00;
                break;
            case "SoftUni Student":
                price = quantity * 1.70;
                break;
            default:
                price = quantity * 1.20;
                break;
        }
        Console.WriteLine($"The {profession} has to pay {price:0.00}.");
    }
}

