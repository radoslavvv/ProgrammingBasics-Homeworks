using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_Exam___28_August_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            int workingDays = int.Parse(Console.ReadLine());
            decimal moneyDaily = decimal.Parse(Console.ReadLine());
            decimal dollar = decimal.Parse(Console.ReadLine());

            decimal monthlyEarning = workingDays * moneyDaily;
            decimal earlyEarnings = monthlyEarning * 12m;
            decimal bonus = monthlyEarning * 2.5m;

            earlyEarnings += bonus;
            earlyEarnings -= earlyEarnings * 0.25m;
            earlyEarnings *= dollar; 


            decimal dailyEaring = earlyEarnings / 365;

            Console.WriteLine(Math.Round(dailyEaring,2));

            


        }
    }
}
