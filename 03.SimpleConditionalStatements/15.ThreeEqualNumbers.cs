using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondtNumber = double.Parse(Console.ReadLine());
            double thirdNumber = double.Parse(Console.ReadLine());

            if (firstNumber == secondtNumber && secondtNumber == thirdNumber) Console.WriteLine("yes");
            else Console.WriteLine("no");
        }
    }
}
