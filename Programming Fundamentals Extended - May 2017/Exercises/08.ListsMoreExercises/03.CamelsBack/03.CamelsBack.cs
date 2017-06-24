using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        List<int> buildings = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        int camelsBackSize = int.Parse(Console.ReadLine());
        int roundsCount = 0;

        if (camelsBackSize == buildings.Count)
        {
            Console.WriteLine($"already stable: {string.Join(" ", buildings)}");
        }
        else
        {
            while (true)
            {
                buildings.RemoveAt(0);
                buildings.RemoveAt(buildings.Count - 1);
                roundsCount++;
                if (buildings.Count == camelsBackSize)
                {
                    Console.WriteLine($"{roundsCount} rounds");
                    Console.WriteLine($"remaining: {string.Join(" ", buildings)}");
                    break;
                }
            }
        }
       
    }
}

