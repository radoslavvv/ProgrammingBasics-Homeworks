using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string command = Console.ReadLine();
        int ingredientsCount = 0;

        while (command != "Bake!")
        {
            Console.WriteLine($"Adding ingredient {command}.");
            ingredientsCount++;

            command = Console.ReadLine();
        }
        Console.WriteLine($"Preparing cake with {ingredientsCount} ingredients.");
    }
}

