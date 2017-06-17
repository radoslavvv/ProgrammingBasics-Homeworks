using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        string[] teens = { "ten","eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        string[] tens = { "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();


            int number = int.Parse(input);
            if (number > 999)
            {
                Console.WriteLine("too large");
                continue;
            }
            else if (number < -999)
            {
                Console.WriteLine("too small");
                continue;
            }
            bool isNegative = false;
            if (input.Length == 4 && input[0] == '-')
            {
                isNegative = true;
                input = input.Substring(1, input.Length - 1);
            }
            if (input.Length == 3)
            {
                string hundreds = $"{digits[int.Parse(input) / 100]}-hundred";
                int currentNumber = int.Parse(input) % 100;

                if (isNegative)
                {
                    Console.Write("minus ");
                }
                if (currentNumber == 0)
                {
                    Console.WriteLine($"{hundreds}");
                    continue;
                }
                if (currentNumber >= 0 && currentNumber < 10)
                {
                    Console.WriteLine($"{hundreds} and {digits[currentNumber]}");
                }
                else if (currentNumber >= 10 && currentNumber < 20)
                {
                    Console.WriteLine($"{hundreds} and {teens[currentNumber - 10]}");
                }
                else
                {
                    if (currentNumber % 10 == 0)
                    {
                        Console.WriteLine($"{hundreds} and {tens[currentNumber / 10 - 2]}");
                    }
                    else
                    {
                        Console.WriteLine($"{hundreds} and {tens[currentNumber / 10 - 2]} {digits[currentNumber % 10]}");
                    }
                }
            }
        }
    }
}

