using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreas
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();

            if (figureType == "square")
            {
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine(a * a);
            }
            else if (figureType == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine(a * b);
            }
            else if (figureType == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.PI * r * r);
            }
            else if (figureType == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine((a * b) / 2);
            }
        }
    }
}
