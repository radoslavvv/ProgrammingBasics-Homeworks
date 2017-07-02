using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        List<string> list = Console.ReadLine()
            .Split()
            .ToList();

        List<string> result = new List<string>();
        for (int i = 0; i < list.Count; i++)
        {
            int[] split = list[i]
                .Split('.')
                .Select(int.Parse)
                .ToArray();

            char firstPart = (char)split[0];
            char secondPart = (char)split[1];


            if (split[0] != 0)
            {
                result.Insert(i, firstPart.ToString());
            }
            if (split[1] != 0)
            {
                result.Insert(result.Count- i, secondPart.ToString());
            }
        }
        Console.WriteLine($"{string.Join("", result)}");
    }
}

