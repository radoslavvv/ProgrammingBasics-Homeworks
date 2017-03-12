using System;

namespace Rocket
{
    class Rocket
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int outsideDots = ((n*3) - 2)/2;
            int insideSpace = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}/{1}\\{0}",new string('.', outsideDots), new string(' ',insideSpace));
                outsideDots -= 1;
                insideSpace += 2;
            }
            outsideDots++;
            Console.WriteLine("{0}{1}{0}",new string('.',outsideDots),new string('*',insideSpace));
            insideSpace -= 2;

            for (int i = 0; i < n*2; i++)
            {
                Console.WriteLine("{0}|{1}|{0}",new string('.',outsideDots),new string('\\',insideSpace));
            }
            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine("{0}/{1}\\{0}",new string('.',outsideDots),new string('*',insideSpace));
                insideSpace+=2;
                outsideDots--;
            }
        }
    }
}
