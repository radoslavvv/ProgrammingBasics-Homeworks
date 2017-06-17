using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int numberBase = int.Parse(Console.ReadLine());
        string result = IntegerToBase(ref number, numberBase);
        Console.WriteLine(result);
    }

    private static string IntegerToBase(ref int number, int numberBase)
    {
        string result = String.Empty;
        while (number > 0)
        {
            int reminder = number % numberBase;
            result = reminder + result;
            number /= numberBase;
        }

        return result;
    }
}

