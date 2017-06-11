using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string[] array = Console.ReadLine().Split(' ');
        string firstElement = array[0];
        
        for (int i = 0; i < array.Length - 1 ; i++)
        {
            array[i] = array[i + 1];
        }
       
        array[array.Length - 1] = firstElement;
        Console.WriteLine(string.Join(" ",array));
    }
}

