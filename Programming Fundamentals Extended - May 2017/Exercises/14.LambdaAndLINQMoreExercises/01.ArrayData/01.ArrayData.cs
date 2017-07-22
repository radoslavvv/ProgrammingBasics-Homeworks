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

        double average = numbers.Average();
        string action = Console.ReadLine();

        numbers.RemoveAll(n => n < average);

        if (action=="Min")
        {
            Console.WriteLine(numbers.Min());    
        }
        else if (action == "Max")
        {
            Console.WriteLine(numbers.Max());
        }
        else
        {
            Console.WriteLine(string.Join(" ",numbers.OrderBy(n=>n)));
        }
    }
}

