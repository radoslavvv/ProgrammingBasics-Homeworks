using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SleepyTom
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOffCount = int.Parse(Console.ReadLine());
            int workDaysCount = 365 - daysOffCount;

            double daysOffPlayTime = 127 * daysOffCount;
            double workDaysPlayTime = 63 * workDaysCount;
            double totalPlayTime = daysOffPlayTime + workDaysPlayTime;

            if(totalPlayTime <= 30000)
            {
                double minutes = 30000 - totalPlayTime;
                TimeSpan timeSpan = TimeSpan.FromMinutes(minutes);

                Console.WriteLine("Tom sleeps well");
               
                Console.WriteLine("{0} hours and {1} minutes less for play",timeSpan.Hours + (timeSpan.Days)*24,timeSpan.Minutes);
            }
            else
            {
                double minutes = totalPlayTime -30000;
                TimeSpan timeSpan = TimeSpan.FromMinutes(minutes);
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play",timeSpan.Hours + (timeSpan.Days) * 24, timeSpan.Minutes);
            }
        }
        }
    }

