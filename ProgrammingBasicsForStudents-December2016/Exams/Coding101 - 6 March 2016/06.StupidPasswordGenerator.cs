using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StupidPasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.Parse(Console.ReadLine());
            int maxLetter = int.Parse(Console.ReadLine());

            for (int firstDigit = 1; firstDigit < maxNumber; firstDigit++)
            {
                for (int secondDigit = 1; secondDigit < maxNumber; secondDigit++)
                {
                    for (int firstLetter = 'a'; firstLetter < maxLetter + 97; firstLetter++)
                    {
                        for (int secondLetter = 'a'; secondLetter < maxLetter + 97; secondLetter++)
                        {
                            for (int lastDigit = Math.Max(firstDigit, secondDigit) + 1; lastDigit <= maxNumber; lastDigit++)
                            {
                                Console.Write("{0}{1}{2}{3}{4} ", firstDigit, secondDigit, (char)firstLetter, (char)secondLetter, lastDigit);
                            }
                        }
                    }
                }
            }
        }
    }
}
