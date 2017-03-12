using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasHat
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int dotsOutside = ((n * 4) - 1) / 2;

            Console.WriteLine("{0}/|\\{0}", new string('.', dotsOutside));
            Console.WriteLine("{0}\\|/{0}", new string('.', dotsOutside));

            for(int i =0;i < n*2; i++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', dotsOutside),new string('-',i));
                dotsOutside--;
            }
            Console.WriteLine(new string('*',4*n+1));
            Console.Write("*");
            for (int i = 0; i < 2*n; i++)
            {
                Console.Write(".*");
            }
            Console.WriteLine();
            Console.WriteLine(new string('*', 4 * n + 1));
        }
    }
}
