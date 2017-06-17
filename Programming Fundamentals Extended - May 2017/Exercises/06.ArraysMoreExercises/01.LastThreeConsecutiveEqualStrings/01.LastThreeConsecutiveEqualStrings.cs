using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string[] strings = Console.ReadLine()
            .Split()
            .Reverse()
            .ToArray();
            

        for (int i = 0; i < strings.Length; i++)
        {
            if((strings[i] == strings[i+1]) &&strings[i+1] == strings[i + 2])
            {
                Console.WriteLine($"{strings[i]} {strings[i]} {strings[i]}");
                break;
            }
        }
    }
}

