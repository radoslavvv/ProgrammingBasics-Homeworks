using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int[] array = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        for (int i = 1; i < array.Length; i++)
        {
            int currentElement = array[i];
            int index = i - 1;

            while (index >= 0 && currentElement < array[index])
            {
                array[index + 1] = array[index];
                index--;
            }
            array[index + 1] = currentElement;
        }
        Console.WriteLine($"{string.Join(" ",array)}");
    }
}

