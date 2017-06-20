using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        List<int> mainList = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        List<int> firstPart = mainList
            .Take(mainList.Count / 2)
            .ToList();

        List<int> secondPart = mainList
            .Skip(mainList.Count / 2)
            .ToList();

        InsertDigits(firstPart, secondPart);

        Console.WriteLine(string.Join(" ", firstPart));
    }

    private static void InsertDigits(List<int> firstPart, List<int> secondPart)
    {
        int index = 0;

        for (int i = 0; i < secondPart.Count; i++)
        {
            int firstDigit = secondPart[i] / 10;
            int secondDigit = secondPart[i] % 10;

            firstPart.Insert(index, firstDigit);
            firstPart.Insert(index + 2, secondDigit);

            index += 3;
        }
    }
}

