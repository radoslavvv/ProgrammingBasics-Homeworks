using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class GrapeAndRakia
{
    static void Main()
    {
        double area = double.Parse(Console.ReadLine());
        double kilograms = double.Parse(Console.ReadLine());
        double brack = double.Parse(Console.ReadLine());

        double totalGrape = area * kilograms;
        totalGrape -= brack;

        double rakiq = (totalGrape * 0.45);
        rakiq /= 7.5;
        rakiq *= 9.8;

        double sold = (totalGrape * 0.55);
        sold *= 1.5;

        Console.WriteLine("{0:0.00}", rakiq);
        Console.WriteLine("{0:0.00}", sold);

    }
}

