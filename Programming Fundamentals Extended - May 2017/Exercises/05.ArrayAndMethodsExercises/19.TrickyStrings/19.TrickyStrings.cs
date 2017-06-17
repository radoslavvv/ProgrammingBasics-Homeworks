using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TrickyStrings
{
    static void Main(string[] args)
    {
        string delimiter = Console.ReadLine();
        int numberOfStrings = int.Parse(Console.ReadLine());

        string result = string.Empty;

        for (int i = 0; i < numberOfStrings; i++)
        {
            string currentString = Console.ReadLine();
            result += currentString + delimiter;
        }
        result = result.Remove(result.Length - delimiter.Length, delimiter.Length);
        Console.WriteLine(result);
    }
}

