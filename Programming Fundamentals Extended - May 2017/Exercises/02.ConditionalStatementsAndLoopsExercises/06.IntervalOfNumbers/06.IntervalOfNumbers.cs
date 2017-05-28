using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());

        int biggerNumber = Math.Max(firstNumber, secondNumber);
        int smallerNumber = Math.Min(firstNumber, secondNumber);

        for (int i = smallerNumber; i <= biggerNumber; i++)
        {
            Console.WriteLine(i);
        }
    }
}

