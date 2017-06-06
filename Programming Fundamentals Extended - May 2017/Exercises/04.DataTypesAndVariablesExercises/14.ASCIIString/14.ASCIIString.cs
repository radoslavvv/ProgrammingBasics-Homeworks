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

        string result = "";
        for (int i = 0; i < n; i++)
        {
            int asciiNumber = int.Parse(Console.ReadLine());
            result += (char) asciiNumber;
        }
        Console.WriteLine(result);
    }
}

