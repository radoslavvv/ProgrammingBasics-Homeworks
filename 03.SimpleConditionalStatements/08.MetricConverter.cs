using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConverterr
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string unit = Console.ReadLine();
            string outUnit = Console.ReadLine();

            double result = 0;
            double mm = 1000;
            double cm = 100;
            double mi = 0.000621371192;
            double inch = 39.3700787;
            double km = 0.001;
            double ft = 3.2808399;
            double yd = 1.0936133;

            switch (unit)
            {
                case "mm":
                    number /= mm;
                    break;
                case "cm":
                    number /= cm;
                    break;
                case "mi":
                    number /= mi;
                    break;
                case "in":
                    number /= inch;
                    break;
                case "km":
                    number /= km;
                    break;
                case "ft":
                    number /= ft;
                    break;
                case "yd":
                    number /= yd;
                    break;

            }
            switch (outUnit)
            {
                case "mm":
                    number *= mm;
                    break;
                case "cm":
                    number *= cm;
                    break;
                case "mi":
                    number *= mi;
                    break;
                case "in":
                    number *= inch;
                    break;
                case "km":
                    number *= km;
                    break;
                case "ft":
                    number *= ft;
                    break;
                case "yd":
                    number *= yd;
                    break;

            }
            Console.WriteLine("{0} {1}", number, outUnit);
        }
    }
}
