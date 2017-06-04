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
        int numbersCount = 0;

        for (int i = 1; i <= 4; i++)
        {
            char first = 'A';
            
            if (i == 1)
            {
                first = 'A';
            }
            else if (i == 2)
            {
                first = 'C';
            }
            else if (i == 3)
            {
                first = 'G';
            }
            else if (i == 4)
            {
                first = 'T';
            }
            for (int j = 1; j <= 4; j++)
            {
                char second = 'A';
                if (j == 1)
                {
                     second = 'A';
                }
                else if (j == 2)
                {
                     second = 'C';
                }
                else if (j == 3)
                {
                     second = 'G';
                }
                else if (j == 4)
                {
                     second = 'T';
                }
                for (int k = 1; k <= 4; k++)
                {
                    char third = 'A';
                    if (k == 1)
                    {
                         third = 'A';
                    }
                    else if (k == 2)
                    {
                         third = 'C';
                    }
                    else if (k == 3)
                    {
                         third = 'G';
                    }
                    else if (k == 4)
                    {
                         third = 'T';
                    }
                    if (i + j + k >= n)
                    {
                        Console.Write($"O{first}{second}{third}O ");
                    }
                    else
                    {
                        Console.Write($"X{first}{second}{third}X ");
                    }
                    numbersCount++;
                    if (numbersCount == 4)
                    {
                        numbersCount = 0;
                        Console.WriteLine();
                    }
                   
                }
            }
        }
    }
}

