using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding101Exam24April
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double tileWidth = double.Parse(Console.ReadLine());
            double tileLenght = double.Parse(Console.ReadLine());
            int benchWidth = int.Parse(Console.ReadLine());
            int benchLenght = int.Parse(Console.ReadLine());

            double totalArea = n * n;
            double tileTotalArea = tileLenght * tileWidth;
            double benchTotalArea = benchLenght * benchWidth;

            totalArea -= benchTotalArea;
            double requiredTiles = totalArea / tileTotalArea;
            double requiredTime = requiredTiles * 0.2;

            Console.WriteLine(requiredTiles);
            Console.WriteLine(requiredTime);
           

        }
    }
}
