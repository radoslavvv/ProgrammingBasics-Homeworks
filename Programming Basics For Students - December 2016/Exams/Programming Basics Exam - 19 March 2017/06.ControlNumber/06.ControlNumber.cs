using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ControlNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int controlNumber = int.Parse(Console.ReadLine());

        int totalSum = 0;
        int turnsCount = 0;

        bool isControled = false;

        for (int i = 1; i <= n; i++)
        {
            for (int a = m; a >= 1; a--)
            {
                totalSum += (i * 2) + (a * 3);
                turnsCount++;

                if (totalSum >= controlNumber)
                {
                    isControled = true;
                    break;
                }
            }
            if (isControled) break;

        }
        if (isControled)
        {
            Console.WriteLine("{0} moves", turnsCount);
            Console.WriteLine("Score: {0} >= {1}", totalSum, controlNumber);
        }
        else
        {
            Console.WriteLine("{0} moves", turnsCount);
        }

    }
}

