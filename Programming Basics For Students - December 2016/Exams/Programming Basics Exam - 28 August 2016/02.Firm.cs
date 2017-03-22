using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal hoursNeeded = decimal.Parse(Console.ReadLine());
            decimal days = decimal.Parse(Console.ReadLine());
            decimal workersCount = decimal.Parse(Console.ReadLine());


            decimal hours = (days - (days * 0.10m)) * 8;
            decimal overtime = workersCount * 2 * days;
            decimal totalTime = hours + overtime;


            totalTime = Math.Floor(totalTime);

            if(totalTime >= hoursNeeded)
            {
                Console.WriteLine("Yes!{0} hours left.", Math.Abs(hoursNeeded - totalTime));
            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.", Math.Abs(totalTime-hoursNeeded));
            }
        
        }
    }
}
