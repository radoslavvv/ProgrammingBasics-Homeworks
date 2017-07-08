using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Dictionary<string, long> numbers = new Dictionary<string, long>();

        string input = Console.ReadLine();
        while (input != "Over")
        {
            string[] split = input.Split();
            long value = 0;
            if (long.TryParse(split[0], out value))
            {
                numbers[split[2]] = value;
            }
            else
            {
                numbers[split[0]] = long.Parse(split[2]);
            }
            input = Console.ReadLine();
        }

        foreach (var number in numbers.OrderBy(n=>n.Key))
        {
            Console.WriteLine($"{number.Key} -> {number.Value}");
        }
      }
}


