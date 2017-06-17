using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string[] numbers = Console.ReadLine().Split();
        string[] names = Console.ReadLine().Split();

        string command = Console.ReadLine();
        
        while (command != "done")
        {
            int index = 0;
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == command)
                {
                    index = i;
                    break;
                }
            }
            Console.WriteLine($"{names[index]} -> {numbers[index]}");
            command = Console.ReadLine();
        }
    }
}

