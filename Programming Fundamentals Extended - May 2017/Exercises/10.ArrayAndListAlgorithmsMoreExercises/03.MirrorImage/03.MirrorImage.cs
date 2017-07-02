using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        List<string> mainList = Console.ReadLine()
            .Split()
            .ToList();

        string command = Console.ReadLine();
        List<string> result = new List<string>();
        while(command != "Print")
        {
            int index = int.Parse(command);
            string middleElement = mainList[index];

            List<string> firstPart = mainList.Take(index).Reverse().ToList();
            List<string> secondPrt = mainList.Skip(index + 1).Reverse().ToList();

            result = new List<string>();

            result.AddRange(firstPart);
            result.Add(middleElement);
            result.AddRange(secondPrt);

            mainList = result;

            command = Console.ReadLine();
        }
        Console.WriteLine($"{string.Join(" ",result)}");
    }
}

