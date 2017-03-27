using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Pets
{
    static void Main()
    {
        decimal daysCount = decimal.Parse(Console.ReadLine());
        decimal foodInKilograms = decimal.Parse(Console.ReadLine());
        decimal dogFood = decimal.Parse(Console.ReadLine());
        decimal catFood = decimal.Parse(Console.ReadLine());
        decimal turtleFood = decimal.Parse(Console.ReadLine());

        decimal dogFoodNeeded = daysCount * dogFood;
        decimal catFoodNeeded = daysCount * catFood;
        decimal turtleFoodNeeded = daysCount * (turtleFood / 1000m);

        decimal totalFoodNeeded = dogFoodNeeded + catFoodNeeded + turtleFoodNeeded;

        if (totalFoodNeeded > foodInKilograms)
        {
            Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(totalFoodNeeded - foodInKilograms));
        }
        else
        {
            Console.WriteLine("{0} kilos of food left.", Math.Floor(foodInKilograms - totalFoodNeeded));
        }
    }
}

