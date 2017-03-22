using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Parallelepiped
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("+{0}+{1}", new string('~', n - 2), new string('.', n * 2 + 1));

        int leftPart = 0;
        int rightPart = n * 2;

        for (int i = 0; i < n * 2 + 1; i++)
        {
            Console.WriteLine(@"|{0}\{1}\{2}", new string('.', leftPart), new string('~', n - 2), new string('.', rightPart));
            leftPart++;
            rightPart--;
        }
        leftPart = 0;
        rightPart = n * 2;

        for (int i = 0; i < n * 2 + 1; i++)
        {
            Console.WriteLine(@"{0}\{1}|{2}|", new string('.', leftPart), new string('.', rightPart), new string('~', n - 2));
            leftPart++;
            rightPart--;
        }
        Console.WriteLine("{0}+{1}+", new string('.', n * 2 + 1), new string('~', n - 2));
    }
}

