using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_Exam___18_December_2016
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal speed = decimal.Parse(Console.ReadLine());
            decimal firstTime = decimal.Parse(Console.ReadLine());
            decimal secondTime = decimal.Parse(Console.ReadLine());
            decimal thirdTime = decimal.Parse(Console.ReadLine());
            
            decimal distanceWithStartSpeed = speed * (firstTime / 60m);
            speed += (speed * 0.10m);
            decimal distanceAfterAcceration = speed * (secondTime / 60m);
            speed -= (speed * 0.05m);
            decimal distanceAterSlow = speed * (thirdTime / 60m);

            decimal total = distanceAfterAcceration + distanceAterSlow + distanceWithStartSpeed;

            Console.WriteLine("{0:0.00}",total);

        }
    }
}
