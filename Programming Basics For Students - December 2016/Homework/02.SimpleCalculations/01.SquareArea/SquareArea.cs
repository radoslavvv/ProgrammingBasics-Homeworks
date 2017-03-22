using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SquareArea
{
    static void Main(string[] args)
    {
        decimal number = decimal.Parse(Console.ReadLine());
        decimal area = number * number;
        Console.WriteLine(area);
    }
}

