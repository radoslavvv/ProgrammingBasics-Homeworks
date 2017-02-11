using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int insideEven = 2;
            int insideOdd = 1;
            int outsideEven = (n / 2) - 1;
            int outsideOdd = n / 2;
            for (int i = 0; i < (n + 1) / 2; i++)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine("{0}{1}{0}", new string('-', outsideEven), new string('*', insideEven));
                    insideEven += 2;
                    outsideEven--;
                }
                else
                {
                    Console.WriteLine("{0}{1}{0}", new string('-', outsideOdd), new string('*', insideOdd));
                    insideOdd += 2;
                    outsideOdd--;
                }
            }
            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine("|{0}|", new string('*', (n - 2)));

            }
        }
    }
}
