using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int[] numbersOcurrences = new int[1000];
        string[] numbersIndexes = new string[1000];

        string[] numbers = Console.ReadLine()
            .Split()
            .ToArray();
        numbers = numbers.Select(int.Parse).OrderBy(x=>x).Select(x=>x.ToString()).ToArray();

        for (int i = 0; i < numbers.Length; i++)
        {
            bool isAvailable = false;
            bool inserted = false;

            for (int j = 0; j < numbersIndexes.Length; j++)
            {
                if (numbersIndexes[j] == numbers[i])
                {
                    isAvailable = true;
                    numbersOcurrences[j]++;
                    break;
                }
            }
            if (!isAvailable)
            {
                for (int j = 0; j < numbersIndexes.Length; j++)
                {
                    if (numbersIndexes[j] == null)
                    {
                        numbersIndexes[j] = numbers[i];
                        numbersOcurrences[j] = 1;
                        inserted = true;
                        break;
                    }
                }
            }
        }

        for (int i = 0; i < numbersOcurrences.Where(x=>x>0).ToArray().Length; i++)
        {
            Console.WriteLine($"{numbersIndexes[i]} => {numbersOcurrences[i]}");
        }
    }
}

