using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_Exam___17_July_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            double bitcoin = 1168;
            double dollar = 1.76;
            double euro = 1.95;
            double uan = 0.15 * dollar;

            double bitcoinsCount = double.Parse(Console.ReadLine());
            double uansCount = double.Parse(Console.ReadLine());
            double commision = double.Parse(Console.ReadLine());

            double total = (bitcoin * bitcoinsCount) + (uan * uansCount);
            total /= euro;
            total -= total * (commision /100);
            Console.WriteLine(total);
        }
    }
}
