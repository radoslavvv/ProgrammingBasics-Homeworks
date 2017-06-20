using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        List<string> lists = Console.ReadLine()
            .Split(new char[] {'|'},StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        List<int> result = new List<int>();

        for (int i = lists.Count - 1; i >=0; i--)
        {
            List<int> currentList = lists[i]
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            result.AddRange(currentList);
        }

        Console.WriteLine(string.Join(" ",result));
    }
}

