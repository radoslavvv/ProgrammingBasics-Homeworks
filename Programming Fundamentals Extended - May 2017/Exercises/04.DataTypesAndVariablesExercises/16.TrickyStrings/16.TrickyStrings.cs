using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string delimiter =(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        string result = "";
        for (int i = 0; i < n; i++)
        {
            string currentWord = Console.ReadLine();

            result += currentWord + delimiter;
        }
        result = result.Remove(result.Length - delimiter.Length, delimiter.Length
            );
        Console.WriteLine(result);
    }
}

