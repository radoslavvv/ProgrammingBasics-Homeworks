using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();

        secondList.RemoveAll(x => firstList.Contains(x));

        if (firstList.Sum() == secondList.Sum())
        {
            Console.WriteLine($"Yes. Sum: {firstList.Sum()}");
        }
        else
        {
            Console.WriteLine($"No. Diff: {Math.Abs(firstList.Sum() - secondList.Sum())}");
        }
    }
}

