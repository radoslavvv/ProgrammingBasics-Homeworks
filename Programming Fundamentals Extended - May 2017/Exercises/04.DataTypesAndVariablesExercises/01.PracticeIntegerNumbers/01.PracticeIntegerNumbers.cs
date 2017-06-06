using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        short first = short.Parse(Console.ReadLine());
        byte second = byte.Parse(Console.ReadLine());
        short third = short.Parse(Console.ReadLine());
        ushort fourth = ushort.Parse(Console.ReadLine());
        uint fifth = uint.Parse(Console.ReadLine());
        int sixth = int.Parse(Console.ReadLine());
        long seventh = long.Parse(Console.ReadLine());

        Console.WriteLine(first);
        Console.WriteLine(second);
        Console.WriteLine(third);
        Console.WriteLine(fourth);
        Console.WriteLine(fifth);
        Console.WriteLine(sixth);
        Console.WriteLine(seventh);
    }
}

