using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TriangleOf55Stars
{
    static void Main()
    {
        for (int i = 0; i < 10; i++)
        {
            for (int a = 0; a <= i; a++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}

