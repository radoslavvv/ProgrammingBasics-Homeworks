using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        List<int> result = new List<int>();

        for (int i = 0; i < n; i++)
        {
            List<int> currentList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            if(result.Count == 0)
            {
                result.AddRange(currentList);
            }
            else
            {
                for (int j = result.Count - 1; j >= 0; j--)
                {
                    if(result[j] < currentList[0])
                    {
                        result.InsertRange(j, currentList);
                    }
                }
            }
        }
    }
}

