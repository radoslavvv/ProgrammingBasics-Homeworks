using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        Console.WriteLine($"{string.Join(" ", numbers.OrderByDescending(n => n).Take(3))}");
        
    }
}

