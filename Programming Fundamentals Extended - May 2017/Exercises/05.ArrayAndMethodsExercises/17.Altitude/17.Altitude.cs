using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        long initialAltitutde = long.Parse(input[0]);
        bool crashed = false;

        for (int i = 1; i < input.Length - 1; i += 2)
        {
            string direction = input[i];
            long altitude = long.Parse(input[i + 1]);

            if (direction == "up")
            {
                initialAltitutde += altitude;
            }
            else if (direction == "down")
            {
                initialAltitutde -= altitude;
            }

            if (initialAltitutde <= 0)
            {
                crashed = true;
                break;
            }
        }
        if (crashed)
        {
            Console.WriteLine("crashed");
        }
        else
        {
            Console.WriteLine($"got through safely. current altitude: {initialAltitutde}m");
        }
    }
}

