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

        switch (profession)
        {
            case "Athlete":
                Console.WriteLine("Water");
                break;
            case "Businessman":
            case "Businesswoman":
                Console.WriteLine("Coffee");
                break;
            case "SoftUni Student":
                Console.WriteLine("Beer");
                break;
            default:
                Console.WriteLine("Tea");
                break;
        }
    }
}

