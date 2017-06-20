using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        List<string> firstList = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        List<string> secondList = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        int minLenght = GetMinimumLength(firstList, secondList);

        RemoveLongerElements(firstList, secondList, minLenght);

        if (firstList.Count == 0)
        {
            Console.WriteLine(string.Join(" ", secondList));
        }
        else if (secondList.Count == 0)
        {
            Console.WriteLine(string.Join(" ", firstList));
        }
        else
        {
            SeparateLists(firstList);
            ZipListsTogether(firstList, secondList);

            Console.WriteLine(string.Join(" ", firstList));
        }
    }

    private static int GetMinimumLength(List<string> firstList, List<string> secondList)
    {
        return firstList
                    .Concat(secondList)
                    .Min(n => Math.Abs(int.Parse(n)))
                    .ToString()
                    .Length;
    }

    private static void ZipListsTogether(List<string> firstList, List<string> secondList)
    {
        int count = 0;
        for (int i = 0; i < firstList.Count; i++)
        {
            if (firstList[i] == String.Empty)
            {
                if (count >= secondList.Count)
                {
                    break;
                }
                firstList[i] = secondList[count];
                count++;
            }
        }

        if (count < secondList.Count)
        {
            firstList.AddRange(secondList.Skip(count));
        }
        firstList.RemoveAll(e => e == String.Empty);
    }

    private static void SeparateLists(List<string> firstList)
    {
        int index = 0;
        for (int i = 0; i < firstList.Count; i++)
        {
            if (index > firstList.Count)
            {
                break;
            }
            firstList.Insert(index, string.Empty);
            index += 2;
        }
    }

    private static void RemoveLongerElements(List<string> firstList, List<string> secondList, int minLenght)
    {
        firstList
            .RemoveAll(n => Math.Abs(int.Parse(n)).ToString().Length != minLenght);
        secondList
            .RemoveAll(n => Math.Abs(int.Parse(n)).ToString().Length != minLenght);
    }
}