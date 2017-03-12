using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            double numbersCount = double.Parse(Console.ReadLine());

            int p1Count = 0;
            int p2Count = 0;
            int p3Count = 0;
            int p4Count = 0;
            int p5Count = 0;

            for (int i = 0; i < numbersCount; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber < 200) p1Count++;
                else if (currentNumber >= 200 && currentNumber < 400) p2Count++;
                else if (currentNumber >= 400 && currentNumber < 600) p3Count++;
                else if (currentNumber >= 600 && currentNumber < 800) p4Count++;
                else p5Count++;
            }

            double p1Percentage = (p1Count / numbersCount) * 100;
            double p2Percentage = (p2Count / numbersCount) * 100;
            double p3Percentage = (p3Count / numbersCount) * 100;
            double p4Percentage = (p4Count / numbersCount) * 100;
            double p5Percentage = (p5Count / numbersCount) * 100;

            Console.WriteLine("{0:0.00}%", p1Percentage);
            Console.WriteLine("{0:0.00}%", p2Percentage);
            Console.WriteLine("{0:0.00}%", p3Percentage);
            Console.WriteLine("{0:0.00}%", p4Percentage);
            Console.WriteLine("{0:0.00}%", p5Percentage);
        }
    }
}
