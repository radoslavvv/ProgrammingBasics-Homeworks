using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            char operatorType = char.Parse(Console.ReadLine());
            double result;

            if (secondNumber == 0)
            {
                Console.WriteLine("Cannot divide {0} by zero", firstNumber);
            }
            else if (operatorType == '+')
            {
                result = firstNumber + secondNumber;

                Console.Write("{0} + {1} = {2} - ", firstNumber, secondNumber, result);
                if (result % 2 == 0) Console.WriteLine("even");
                else Console.WriteLine("odd");
            }
            else if (operatorType == '*')
            {
                result = firstNumber * secondNumber;

                Console.Write("{0} * {1} = {2} - ", firstNumber, secondNumber, result);
                if (result % 2 == 0) Console.WriteLine("even");
                else Console.WriteLine("odd");
            }
            else if (operatorType == '-')
            {
                result = firstNumber - secondNumber;

                Console.Write("{0} - {1} = {2} - ", firstNumber, secondNumber, result);
                if (result % 2 == 0) Console.WriteLine("even");
                else Console.WriteLine("odd");
            }
            else if (operatorType == '/')
            {
                result = firstNumber / secondNumber;
                Console.WriteLine("{0} / {1} = {2:0.00}", firstNumber, secondNumber, result);
            }
            else if (operatorType == '%')
            {
                result = firstNumber % secondNumber;
                Console.WriteLine("{0} % {1} = {2}", firstNumber, secondNumber, result);
            }
        }
    }
}
