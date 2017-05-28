﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int ingredientsCount = int.Parse(Console.ReadLine());

        int caloriesCount = 0;

        for (int i = 0; i < ingredientsCount; i++)
        {
            string ingredient = Console.ReadLine().ToLower();

            switch (ingredient)
            {
                case "cheese":
                    caloriesCount += 500;
                    break;
                case "tomato sauce":
                    caloriesCount += 150;
                    break;
                case "salami":
                    caloriesCount += 600;
                    break;
                case "pepper":
                    caloriesCount += 50;
                    break;
            }
        }
        Console.WriteLine($"Total calories: {caloriesCount}");
    }
}

