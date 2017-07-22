using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        List<int> tokens = Console.ReadLine().Split().Select(int.Parse).ToList();


        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        int m = tokens[0];
        int n = tokens[1];


        List<int> result = numbers.Where(num=>num >= 65 && num <=90).Skip(m).Where(num => num >= 65 && num <= 90).Take(n).ToList();

        foreach (var character in result)
        {
            Console.Write((char)character);
        }
        Console.WriteLine();
    }
}

