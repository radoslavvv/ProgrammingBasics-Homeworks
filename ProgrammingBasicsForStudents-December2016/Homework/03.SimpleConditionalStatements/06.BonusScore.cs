using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            double points = double.Parse(Console.ReadLine());
            double bonusPoints = 0;

            if (points <= 100)
            {
                bonusPoints = 5;
            }
            else if (points > 1000)
            {
                bonusPoints = points * 0.10;
            }
            else if (points > 100)
            {
                bonusPoints = points * 0.20;
            }


            if (points % 2 == 0)
            {
                bonusPoints++;
            }
            if (points % 10 == 5)
            {
                bonusPoints += 2;
            }
            double totalPoints = points + bonusPoints;

            Console.WriteLine(bonusPoints);
            Console.WriteLine(totalPoints);
        }
    }
}
