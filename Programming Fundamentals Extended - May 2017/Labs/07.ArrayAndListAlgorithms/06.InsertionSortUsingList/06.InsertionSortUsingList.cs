using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        List<int> list = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        List<int> result = new List<int>();

        for (int i = 0; i < list.Count; i++)
        {
            if (result.Count == 0)
            {
                result.Add(list[i]);
            }
            else
            {
                int index = result.Count - 1;
                int currentElement = list[i];

                while (index >= 0 && currentElement < result[index])
                {
                    index--;
                }
                result.Insert(index + 1 ,currentElement);
            }
        }
        Console.WriteLine($"{string.Join(" ", result)}");
    }
}

