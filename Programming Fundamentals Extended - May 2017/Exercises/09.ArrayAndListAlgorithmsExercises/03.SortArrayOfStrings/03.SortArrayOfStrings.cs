using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        List<string> strings = Console.ReadLine()
            .Split()
            .ToList();

        for (int i = 1; i < strings.Count; i++)
        {
            string currentString = strings[i];
            int index = i - 1;

            while (index >= 0 && strings[index].CompareTo(currentString) > 0)
            {
                strings[index + 1] = strings[index];
                index--;
            }
            strings[index + 1] = currentString;
        }

        Console.WriteLine($"{string.Join(" ", strings)}");
    }
}


