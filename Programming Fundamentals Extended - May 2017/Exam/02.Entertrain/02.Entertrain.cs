using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int trainPower = int.Parse(Console.ReadLine());
        List<int> train = new List<int>();

        string input = Console.ReadLine();
        while (input != "All ofboard!")
        {
            int currentWagon = int.Parse(input);

            train.Add(currentWagon);
            if (train.Sum() > trainPower)
            {
                RemoveWagon(train);
            }

            input = Console.ReadLine();
        }
        train.Reverse();
        Console.WriteLine($"{string.Join(" ", train)} {trainPower}");
    }

    private static void RemoveWagon(List<int> train)
    {
        int trainAverage = train.Sum() / train.Count;

        int wagonToRemove = 0;
        int closestDifference = int.MaxValue;
        foreach (int wagon in train)
        {
            int difference = Math.Abs(trainAverage - wagon);
            if (difference <= closestDifference)
            {
                closestDifference = difference;
                wagonToRemove = wagon;
            }
        }
        train.Remove(wagonToRemove);
    }
}

