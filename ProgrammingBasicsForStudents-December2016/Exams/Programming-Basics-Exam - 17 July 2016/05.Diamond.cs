using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{0}",new string('.',n),new string('*', n*3));
            int insideDots = n * 3;

            for (int i = 1; i <= n-1; i++)
            {
                Console.WriteLine("{0}*{1}*{0}",new string('.',n-i),new string('.', insideDots));
                insideDots += 2;
            }
            Console.WriteLine("{0}",new string('*',n*5));
            int outsideDots = 0;
            for (int i = 1; i <= (n*2); i++)
            {
                Console.WriteLine("{0}*{1}*{0}",new string('.',i),new string('.', insideDots - 2));
                insideDots -= 2;
                outsideDots = i +1 ;
            }
            Console.WriteLine("{0}{1}{0}",new string('.', outsideDots), new string('*', insideDots));
        }
    }
}
