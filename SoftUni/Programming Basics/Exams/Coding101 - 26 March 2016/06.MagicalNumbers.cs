using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MagicalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int magicalNumber = int.Parse(Console.ReadLine());
            List<int> magicalNumbers = new List<int>();

            for (int i = 111111; i <= 999999; i++)
            {
                int digitsSum = 1;
                int currentNumber = i;

                while (currentNumber > 0)
                {
                    int lastDigit = currentNumber % 10;
                    digitsSum *= lastDigit;
                    currentNumber /= 10;
                }
                if (digitsSum == magicalNumber)
                {
                    magicalNumbers.Add(i);
                }
            }
            Console.WriteLine(string.Join(" ", magicalNumbers));
        }
    }
}
