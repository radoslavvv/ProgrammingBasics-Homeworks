using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SmartLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washerPrice = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());

            int toysCount = 0;
            double savedMoney = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    savedMoney += ( (i * 10) / 2) - 1;
                }
                else if (i % 2 != 0)
                {
                    toysCount++;
                }
            }
            double soldToysPrice = toysCount * toyPrice;
            savedMoney += soldToysPrice;

            if (savedMoney >= washerPrice)
            {
                Console.WriteLine("Yes! {0:0.00}", savedMoney - washerPrice);
            }
            else if (washerPrice > savedMoney)
            {
                Console.WriteLine("No! {0:0.00}", washerPrice - savedMoney);
            }
        }
    }
}
