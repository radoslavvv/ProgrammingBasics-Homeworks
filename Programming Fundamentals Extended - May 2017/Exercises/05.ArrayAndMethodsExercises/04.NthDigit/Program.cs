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
        int nthDigit = int.Parse(Console.ReadLine());

        string stringNumber = number.ToString();

        Console.WriteLine(stringNumber[stringNumber.Length - nthDigit]);
    }
}
