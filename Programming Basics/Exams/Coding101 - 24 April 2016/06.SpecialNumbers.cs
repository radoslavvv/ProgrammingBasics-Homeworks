using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<int> specialNumbers = new List<int>();
            
            for (int i = 1111; i <= 9999; i++)
            {
                List<int> digits = new List<int>();
                int currentNumber = i;

                while(currentNumber >= 10)
                {
                    digits.Add(currentNumber % 10); 
                    currentNumber /= 10;
                }
                digits.Add(currentNumber);

                bool numberIsSpecial = true;

                foreach (var digit in digits)
                {
                    if (digit == 0)
                    {
                        numberIsSpecial = false;
                        continue;
                    }

                    if (number % digit != 0)
                    {
                        numberIsSpecial = false;
                        break;       
                    }
                }
                if (numberIsSpecial) specialNumbers.Add(i);
            }
            Console.WriteLine(string.Join(" ",specialNumbers));
        }
    }
}
