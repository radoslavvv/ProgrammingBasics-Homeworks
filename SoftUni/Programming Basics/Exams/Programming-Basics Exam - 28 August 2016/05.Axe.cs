using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int rows = 0;
            int leftSide = n*3;
            int rightSide = (n * 2) - 2;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}*{1}*{2}",new string('-',leftSide),new string('-',i),new string('-',rightSide));
                rightSide--;
                rows++;
            }
            rightSide++;
            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine("{0}*{1}*{2}",new string('*', n*3),new string('-',n-1), new string('-', rightSide));
                rows++;
            }
            int inside = n - 1;
            int number = 0;
           for (int i = 0; i < (n/2) -1 ; i++)
            {
                Console.WriteLine("{0}*{1}*{2}",new string('-',leftSide),new string('-', inside), new string('-',rightSide));
                leftSide--;
                rightSide--;
                inside+=2;
                number++;
            }
            leftSide = (n * 3) - number;

           if (n%2 != 0)
            {
                Console.WriteLine("{0}{1}{2}", new string('-', leftSide), new string('*',(n *2) - 2), new string('-', rightSide));
            }
           else
            {
                Console.WriteLine("{0}{1}{2}", new string('-', leftSide), new string('*',(n * 2)-1), new string('-', rightSide));
            }



           
        }
    }
}

