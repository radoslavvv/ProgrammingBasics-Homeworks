using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        char fistLetter = char.Parse(Console.ReadLine());
        char secondLetter = char.Parse(Console.ReadLine());
        char forbiddenLetter = char.Parse(Console.ReadLine());

        for (int i = fistLetter; i <= secondLetter; i++)
        {
            for (int j = fistLetter; j <= secondLetter; j++)
            {
                for (int k = fistLetter; k <= secondLetter; k++)
                {
                    if (!(i == forbiddenLetter || j == forbiddenLetter || k == forbiddenLetter))
                    {
                        Console.Write($"{(char)i}{(char)j}{(char)k} ");
                    }
                }
            }
        }
    }
}

