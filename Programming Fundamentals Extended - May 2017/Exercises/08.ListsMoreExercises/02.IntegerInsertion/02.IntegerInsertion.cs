using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        string command = Console.ReadLine();

        while (command != "end")
        {
            int number = int.Parse(command);
            int index = int.Parse(command[0].ToString());
            numbers.Insert(index,number);
            command = Console.ReadLine();
        }

        Console.WriteLine($"{string.Join(" ",numbers)}");
    }
}

