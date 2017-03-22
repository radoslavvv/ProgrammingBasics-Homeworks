using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.StopSign
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int backgroundCount = n + 1;
            int insideCount = (n * 2) + 1;

            Console.WriteLine("{0}{1}{0}",new string('.', backgroundCount),new string('_', insideCount));
            backgroundCount--;
            insideCount-=2;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(@"{0}//{1}\\{0}",new string('.',backgroundCount),new string('_',insideCount));
                backgroundCount--;
                insideCount += 2;
            }

            Console.WriteLine(@"{0}//{1}STOP!{1}\\{0}", new string('.', backgroundCount), new string('_', (insideCount - 5)/2));

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(@"{0}\\{1}//{0}", new string('.', backgroundCount), new string('_', insideCount));
                backgroundCount++;
                insideCount -= 2;
            }
        }
    }
}
