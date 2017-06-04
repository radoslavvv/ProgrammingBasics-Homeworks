using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string fistName = Console.ReadLine();
        string lastName = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine($"Hello, {fistName} {lastName}. You are {age} years old.");
    }
}

