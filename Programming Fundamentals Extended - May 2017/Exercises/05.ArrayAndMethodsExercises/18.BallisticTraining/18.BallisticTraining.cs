using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int[] targetCoordinates = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        int targeX = targetCoordinates[0];
        int targetY = targetCoordinates[1];

        string[] commands = Console.ReadLine().Split();

        int firingX = 0;
        int firingY = 0;

        for (int i = 0; i < commands.Length - 1; i += 2)
        {
            string direction = commands[i];
            int value = int.Parse(commands[i + 1]);

            switch (direction)
            {
                case "up":
                    firingY += value;
                    break;
                case "down":
                    firingY -= value;
                    break;
                case "left":
                    firingX -= value;
                    break;
                case "right":
                    firingX += value;
                    break;
            }
        }

        Console.WriteLine($"firing at [{firingX}, {firingY}]");
        if (firingY == targetY && firingX == targeX)
        {
            Console.WriteLine("got 'em!");
        }
        else
        {
            Console.WriteLine("better luck next time...");
        }
    }
}

