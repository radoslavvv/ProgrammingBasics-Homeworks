using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Fox
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int outside = 1;
        int inside = n * 2 - 1;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(@"{0}\{1}/{0}", new string('*', outside), new string('-', inside));
            inside -= 2;
            outside++;
        }
        inside = n;
        outside = n / 2;

        for (int i = 0; i < n / 3; i++)
        {
            Console.WriteLine(@"|{0}\{1}/{0}|", new string('*', outside), new string('*', inside));
            inside -= 2;
            outside++;
        }
        inside = n * 2 - 1;
        outside = 1;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(@"{0}\{1}/{0}", new string('-', outside), new string('*', inside));
            inside -= 2;
            outside++;
        }
    }
}

