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
        char sign = char.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());

        int result = 0;
        switch (sign)
        {
            case '+':
                result = firstNumber + secondNumber;
                break;
            case '-':
                result = firstNumber - secondNumber;
                break;
            case '*':
                result = firstNumber * secondNumber;
                break;
            case '/':
                result = firstNumber / secondNumber;
                break;
        }
        Console.WriteLine($"{firstNumber} {sign} {secondNumber} = {result}");

    }
}

