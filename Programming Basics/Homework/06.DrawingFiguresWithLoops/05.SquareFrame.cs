using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTopAndBottom(n);

            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("| ");
                for (int a = 0; a < n - 2; a++)
                {
                    Console.Write("- ");
                }
                Console.WriteLine("|");
            }

            PrintTopAndBottom(n);

        }
        private static void PrintTopAndBottom(int n)
        {
            Console.Write("+ ");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+");
        }
    }
}
