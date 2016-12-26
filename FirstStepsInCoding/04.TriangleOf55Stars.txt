using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleOfStars
{
    class Program
    {
        static void Main(string[] args)
        {

            for(int i = 0; i < 10; i++)
            {
                for(int a = 0; a <= i; a++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
