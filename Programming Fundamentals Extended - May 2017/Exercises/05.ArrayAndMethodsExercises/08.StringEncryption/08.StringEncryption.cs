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
        string result = string.Empty;
        for (int i = 0; i < n; i++)
        {
            char currentChar = char.Parse(Console.ReadLine());

            result += EncryptCharacter(currentChar);
        }
        Console.WriteLine(result);
    }

    private static string EncryptCharacter(char currentChar)
    {
        string code = ((int)currentChar).ToString();

        int lastDigit = int.Parse(code[code.Length - 1].ToString());
        int firstDigit = int.Parse(code[0].ToString());

        char firstChar = (char)(int.Parse(code) + lastDigit);
        char secondChar = (char)(int.Parse(code) - firstDigit);

        string result = $"{firstChar}{firstDigit}{lastDigit}{secondChar}";
        return result;
    }
}

