using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        List<int> grapes = Console.ReadLine()
            .Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        int roundsCount = int.Parse(Console.ReadLine());
        List<int> lesserGrapesIndexes = new List<int>();

        while (grapes.Count(g => g > 0) >= roundsCount)
        {
            for (int i = 0; i < roundsCount; i++)
            {
                IncrementAll(grapes);
                ProcessGrapes(grapes, lesserGrapesIndexes);
                SetToZero(grapes);

                lesserGrapesIndexes.Clear();
            }
            RemoveSmallerGrapes(grapes, roundsCount);
        }
        Console.WriteLine($"{string.Join(" ",grapes.Where(g=>g >0))}");
    }

    private static void RemoveSmallerGrapes(List<int> grapes, int roundsCount)
    {
        for (int i = 0; i < grapes.Count; i++)
        {
            if (grapes[i] <= roundsCount)
            {
                grapes[i] = 0;
            }
        }
    }

    private static void ProcessGrapes(List<int> grapes, List<int> lesserGrapesIndexes)
    {
        for (int j = 1; j < grapes.Count - 1; j++)
        {
            if (grapes[j] > grapes[j - 1] && grapes[j] > grapes[j + 1])
            {
                if (!lesserGrapesIndexes.Contains(j + 1))
                {
                    lesserGrapesIndexes.Add(j + 1);
                    grapes[j + 1]--;
                }
                if (!lesserGrapesIndexes.Contains(j - 1))
                {
                    lesserGrapesIndexes.Add(j - 1);
                    grapes[j - 1]--;
                }

                if (grapes[j - 1] > 0)
                {
                    grapes[j - 1]--;
                    grapes[j]++;
                }
                if (grapes[j + 1] > 0)
                {
                    grapes[j + 1]--;
                    grapes[j]++;
                }
            }
        }
    }

    private static void SetToZero(List<int> grapes)
    {
        for (int j = 0; j < grapes.Count; j++)
        {
            if (grapes[j] < 0)
            {
                grapes[j] = 0;
            }
        }
    }

    private static void IncrementAll(List<int> grapes)
    {
        for (int j = 0; j < grapes.Count; j++)
        {
            if (grapes[j] > 0)
            {
                grapes[j]++;
            }
        }
    }
}

