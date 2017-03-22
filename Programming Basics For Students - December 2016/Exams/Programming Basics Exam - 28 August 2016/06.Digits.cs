using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string digits = Convert.ToString(number);

            int firstDigit = digits[0] - '0';
            int secondDigit = digits[1] - '0';
            int thirdDigit = digits[2] - '0';

           

            for(int i =0; i< firstDigit + secondDigit; i++)
            {
                for(int a = 0; a < firstDigit + thirdDigit; a++)
                {
                    if (number % 5 == 0)
                    {
                        number -= firstDigit;
                    }
                    else if (number % 3 == 0)
                    {
                        number -= secondDigit;
                    }
                    else
                    {
                        number += thirdDigit;
                    }
                    

                    Console.Write("{0} ",number);
                }
                Console.WriteLine();
            }
        }
    }
}

