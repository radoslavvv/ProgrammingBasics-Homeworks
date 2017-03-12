using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int years = 18;
            for (int i = 1800; i <= year; i++)
            {
                
                if(i % 2 == 0)
                {
                    money -= 12000;
                }
                else if(i%2 != 0)
                {
                    money -= 12000 + (50 * (years));
                }
                years++;
            }
            if (money >= 0)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:0.00} dollars left.", money);
            }
            else if(money < 0)
            {
                Console.WriteLine("He will need {0:0.00} dollars to survive.",Math.Abs(money));
            }
        }
    }
}
