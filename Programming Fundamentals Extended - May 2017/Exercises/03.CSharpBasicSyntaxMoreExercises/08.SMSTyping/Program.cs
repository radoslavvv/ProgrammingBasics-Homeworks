using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string message = string.Empty;

        for (int i = 0; i < n; i++)
        {
            string number = Console.ReadLine();
            if (number == "0")
            {
                message += ' ';
                continue;
            }
            int numbersCount = number.Length;
            int mainDigit = int.Parse(number[0].ToString());
            int offset = (mainDigit - 2) * 3;

            if (mainDigit == 8 || mainDigit == 9)
            {
                offset++;
            }

            int index = offset + numbersCount - 1;
            char letter = (char) (index + 97);
            message += letter;
        }
        Console.WriteLine(message);
    }
}

