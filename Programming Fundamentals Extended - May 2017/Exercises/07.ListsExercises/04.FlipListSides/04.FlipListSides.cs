using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

        FlipSides(list);

        Console.WriteLine(string.Join(" ", list));
    }

    private static void FlipSides(List<int> list)
    {
        for (int i = 1; i < list.Count / 2; i++)
        {
            int firstNumber = list[i];
            list[i] = list[list.Count - 1 - i];
            list[list.Count - 1 - i] = firstNumber;
        }
    }
}

