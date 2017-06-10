using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        double number = double.Parse(Console.ReadLine());
        int power = int.Parse(Console.ReadLine());

        double result = GetPoweredNumber(number, power);

        Console.WriteLine(result);
    }

    static double GetPoweredNumber(double number, int power)
    {
        double result = Math.Pow(number, power);
        return result;
    }
}

