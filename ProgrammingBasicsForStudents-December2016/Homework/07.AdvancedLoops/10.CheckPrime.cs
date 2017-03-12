using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isPrime = false;

            if (n == 2)
            {
                Console.WriteLine("Prime");
                return; 
            }

            if (n > 2)
            {
                isPrime = true;
                for (int i = 2; i <= Math.Ceiling(Math.Sqrt(n)); i++)
                {
                    if (n % i == 0) isPrime = false;
                }
            }
            if (isPrime)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
        }
    }
}
