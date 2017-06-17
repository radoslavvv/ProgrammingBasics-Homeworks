using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int repeatCount = int.Parse(Console.ReadLine());

        input = RepeatString(input, repeatCount);
        Console.WriteLine(input);
    }

    private static string RepeatString(string input, int repeatCount)
    {
        string result = String.Empty;
        for (int i = 0; i < repeatCount; i++)
        {
            result += input;
        }

        return result;
    }
}

