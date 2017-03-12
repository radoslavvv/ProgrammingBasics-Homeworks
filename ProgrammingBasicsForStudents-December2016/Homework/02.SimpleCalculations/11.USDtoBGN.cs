using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromUSDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double course = 1.79549;

            double usd = double.Parse(Console.ReadLine());

            double bng = usd * course;

            Console.WriteLine(Math.Round(bng,2));
        }
    }
}
