using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int integersCount = 0;
        while (true)
        {
            string input = Console.ReadLine();
            int number = 0;
            bool isInteger = int.TryParse(input, out number);

            if (isInteger)
            {
                integersCount++;
            }
            else
            {
                break;
            }
        }
        Console.WriteLine(integersCount);
    }
}

