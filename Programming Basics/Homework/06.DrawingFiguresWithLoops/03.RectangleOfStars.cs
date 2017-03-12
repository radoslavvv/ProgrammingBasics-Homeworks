using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("*");
                for (int a = 0; a < n - 1; a++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
