using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        List<int> elements = new List<int>();
        int lastElementShot = 0;
        bool listIsEmpty = false;

        string command = Console.ReadLine();
        while (command != "stop")
        {
            if (command == "bang")
            {
                if (elements.Count == 0)
                {
                    Console.WriteLine($"nobody left to shoot! last one was {lastElementShot}");
                    listIsEmpty = true;
                    break;
                }
                else
                {
                    Bang(ref elements, ref lastElementShot);
                }
            }
            else
            {
                Insert(command, elements);
            }

            command = Console.ReadLine();
        }
        if (!listIsEmpty)
        {
            if (elements.Count == 0)
            {
                Console.WriteLine($"you shot them all. last one was {lastElementShot}");
            }
            else
            {
                Console.WriteLine($"survivors: {string.Join(" ", elements)}");
            }
        }
    }

    private static void Insert(string command, List<int> elements)
    {
        int currentElement = int.Parse(command);
        elements.Insert(0, currentElement);
    }

    private static void Bang(ref List<int> elements, ref int lastElementShot)
    {
        double averageSum = elements.Average();
        for (int i = 0; i < elements.Count; i++)
        {
            if (elements[i] <= averageSum)
            {
                Console.WriteLine($"shot {elements[i]}");

                lastElementShot = elements[i];
                elements.RemoveAt(i);

                elements = elements
                    .Select(e => --e)
                    .ToList();

                break;
            }
        }
    }
}


