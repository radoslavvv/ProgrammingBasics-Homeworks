using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();


        int number = int.Parse(Console.ReadLine());
        bool isContained = false;

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] == number)
            {
                Console.WriteLine("yes");
                isContained = true;
                break;
            }
        }
        if (!isContained)
        {
            Console.WriteLine("no");
        }
    }
}

