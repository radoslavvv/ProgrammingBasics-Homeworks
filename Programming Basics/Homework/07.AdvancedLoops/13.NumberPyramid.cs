using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;

            for (int row = 1; row <= n; row++)
            {
                for (int collon = 1; collon <= row; collon++)
                {
                    Console.Write(num + " ");
                    num++;
                    if (num > n) break;
                }
                if (num > n) break;
                Console.WriteLine();
            }
        }
    }
}
