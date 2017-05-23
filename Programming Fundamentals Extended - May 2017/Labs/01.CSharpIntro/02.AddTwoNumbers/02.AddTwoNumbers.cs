using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AddTwoNumbers
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int sum = firstNumber + secondNumber;

        Console.WriteLine($"{firstNumber} + {secondNumber} = {sum}");
    }
}

