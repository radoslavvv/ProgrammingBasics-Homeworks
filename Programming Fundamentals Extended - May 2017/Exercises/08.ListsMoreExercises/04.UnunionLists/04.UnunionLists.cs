using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        List<int> primaList = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            List<int> currentList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            for (int j = 0; j < currentList.Count; j++)
            {
                if (primaList.Contains(currentList[j]))
                {
                    primaList.RemoveAll(x => x == currentList[j]);
                }
                else
                {
                    primaList.Add(currentList[j]);
                }
            }
        }
        primaList.Sort();
        Console.WriteLine($"{string.Join(" ",primaList)}");
    }
}

