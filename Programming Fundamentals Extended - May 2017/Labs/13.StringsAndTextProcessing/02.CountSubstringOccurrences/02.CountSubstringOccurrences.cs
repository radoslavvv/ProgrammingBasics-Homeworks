using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string text = Console.ReadLine().ToLower();
        string substring = Console.ReadLine().ToLower();


        int index = text.IndexOf(substring);
        int count = 0;
        while (index != -1)
        {
            count++;
            index = text.IndexOf(substring, index + 1);
        }

        Console.WriteLine(count);
    }
}

