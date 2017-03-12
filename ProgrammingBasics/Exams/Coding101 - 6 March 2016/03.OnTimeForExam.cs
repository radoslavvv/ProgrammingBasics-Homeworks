using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.OnTimeForExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinute = int.Parse(Console.ReadLine());

            int examTime = (examHour * 60) + examMinute;
            int arrivalTime = (arrivalHour * 60) + arrivalMinute;

            int diff = arrivalTime - examTime;

            if(diff < -30) Console.WriteLine("Early");
            else if(diff <= 0) Console.WriteLine("On time");
            else Console.WriteLine("Late");

            if(diff != 0)
            {
                int hours = Math.Abs(diff / 60);
                int minutes = Math.Abs(diff % 60);

                if(hours > 0)
                {
                    Console.Write("{0}:{1:00} hours ",hours,minutes);
                }
                else
                {
                    Console.Write("{0} minutes ",minutes);
                }

                if (diff < 0)
                {
                    Console.Write("before the start");
                }
                else
                {
                    Console.Write("after the start");
                }
                Console.WriteLine();
            }

        }
    }
}
