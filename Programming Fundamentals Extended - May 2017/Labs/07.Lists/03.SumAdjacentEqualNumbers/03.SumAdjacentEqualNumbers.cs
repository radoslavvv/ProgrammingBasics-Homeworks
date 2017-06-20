using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        List<double> list = Console.ReadLine()
            .Split()
            .Select(double.Parse)
            .ToList();

        for (int i = 0; i < list.Count - 1; i++)
        {
            if (list[i] == list[i + 1])
            {
                list[i] += list[i + 1];
                list.RemoveAt(i+1);
                i = -1;
            }
        }
        Console.WriteLine(string.Join(" ",list));
    }
}

