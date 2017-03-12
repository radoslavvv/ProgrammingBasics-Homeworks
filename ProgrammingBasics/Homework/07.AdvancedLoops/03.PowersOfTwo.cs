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

            Console.WriteLine(1);
            int number = 2;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(number);
                number *= 2;
            }
        }
    }
}
