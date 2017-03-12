﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            while (secondNumber != 0)
            {
                int leftOver = secondNumber;
                secondNumber = firstNumber % secondNumber;
                firstNumber = leftOver; 
            }
            Console.WriteLine(firstNumber);
        }
    }
}
