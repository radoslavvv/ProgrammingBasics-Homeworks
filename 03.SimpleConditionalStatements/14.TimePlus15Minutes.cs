using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plus15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());

            minute += 15;
            if (minute >= 60)
            {
                hour++;
                minute -= 60;

                if (hour >= 24)
                {
                    hour -= 24;
                }
            }
            Console.WriteLine("{0:0}:{1:00}", hour, minute);
        }
    }
}
