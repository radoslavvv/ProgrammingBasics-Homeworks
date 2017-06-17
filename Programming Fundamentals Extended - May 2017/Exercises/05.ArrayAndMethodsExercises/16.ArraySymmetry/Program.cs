using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string[] array = Console.ReadLine().Split();

        bool areEqual = true;
        for (int i = 0; i < array.Length / 2; i++)
        {
            string firstElement = array[i];
            string secondElement = array[array.Length -1 - i];

            if (firstElement != secondElement)
            {
                areEqual = false;
                break;
            }
        }
        if (areEqual)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}

