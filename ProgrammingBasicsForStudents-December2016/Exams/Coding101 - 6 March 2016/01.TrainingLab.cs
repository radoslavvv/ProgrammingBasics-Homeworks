using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding101_6March2016
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            width *= 100;
            lenght *= 100;

            double hallway = 100;
            width -= hallway;

            int desksInRow = (int)(width / 70);
            int rows = (int)(lenght / 120);

            int totalSeats = (desksInRow * rows) -3;

            Console.WriteLine(totalSeats);
        }
    }
}
