using System;

namespace SimpleConditionalStatements
{
    class SimpleConditionalStatements
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int number = int.Parse(input);
            if (number >= 0 && number <= 100)
            {
                int firstDigit = int.Parse(input[0].ToString());
                if (number == 100)
                {
                    Console.WriteLine("one hundred");
                }
                else if (input.Length == 1)
                {
                    if (firstDigit == 0) Console.WriteLine("zero");
                    if (firstDigit == 1) Console.WriteLine("one");
                    if (firstDigit == 2) Console.WriteLine("two");
                    if (firstDigit == 3) Console.WriteLine("three");
                    if (firstDigit == 4) Console.WriteLine("four");
                    if (firstDigit == 5) Console.WriteLine("five");
                    if (firstDigit == 6) Console.WriteLine("six");
                    if (firstDigit == 7) Console.WriteLine("seven");
                    if (firstDigit == 8) Console.WriteLine("eight");
                    if (firstDigit == 9) Console.WriteLine("nine");
                }
                else if (input.Length == 2)
                {
                    int secondDigit = int.Parse(input[1].ToString());

                    if (firstDigit == 1)
                    {
                        if (secondDigit == 0) Console.WriteLine("ten");
                        else if (secondDigit == 1) Console.WriteLine("eleven");
                        else if (secondDigit == 2) Console.WriteLine("twelve");
                        else if (secondDigit == 3) Console.WriteLine("thirteen");
                        else if (secondDigit == 4) Console.WriteLine("fourteen");
                        else if (secondDigit == 5) Console.WriteLine("fifteen");
                        else if (secondDigit == 6) Console.WriteLine("sixteen");
                        else if (secondDigit == 7) Console.WriteLine("seventeen");
                        else if (secondDigit == 8) Console.WriteLine("eighteen");
                        else if (secondDigit == 9) Console.WriteLine("nineteen");
                    }
                    else if (firstDigit > 1)
                    {
                        if (firstDigit == 2) Console.Write("twenty");
                        else if (firstDigit == 3) Console.Write("thirty");
                        else if (firstDigit == 4) Console.Write("fourty");
                        else if (firstDigit == 5) Console.Write("fifty");
                        else if (firstDigit == 6) Console.Write("sixty");
                        else if (firstDigit == 7) Console.Write("seventy");
                        else if (firstDigit == 8) Console.Write("eighty");
                        else if (firstDigit == 9) Console.Write("ninety");

                        if (secondDigit == 1) Console.WriteLine(" one");
                        if (secondDigit == 2) Console.WriteLine(" two");
                        if (secondDigit == 3) Console.WriteLine(" three");
                        if (secondDigit == 4) Console.WriteLine(" four");
                        if (secondDigit == 5) Console.WriteLine(" five");
                        if (secondDigit == 6) Console.WriteLine(" six");
                        if (secondDigit == 7) Console.WriteLine(" seven");
                        if (secondDigit == 8) Console.WriteLine(" eight");
                        if (secondDigit == 9) Console.WriteLine(" nine");
                    }
                }
            }
            else
            {
                Console.WriteLine("invalid number");
            }
        }
    }
}
