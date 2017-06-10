using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string type = Console.ReadLine();
        if (type == "int")
        {
            int firstParameter = int.Parse(Console.ReadLine());
            int secondParameter = int.Parse(Console.ReadLine());

            int max = GetMax(firstParameter, secondParameter);
            Console.WriteLine(max);
        }
        else if (type == "char")
        {
            char firstParameter = char.Parse(Console.ReadLine());
            char secondParameter = char.Parse(Console.ReadLine());

            char max = GetMax(firstParameter, secondParameter);
            Console.WriteLine(max);
        }
        else if (type == "string")
        {
            string firstParameter = Console.ReadLine();
            string secondParameter = Console.ReadLine();
            
            string max = GetMax(firstParameter, secondParameter);
            Console.WriteLine(max);
        }

        
    }

    static int GetMax(int firstParameter, int secondParameter)
    {
        if (firstParameter > secondParameter)
        {
            return firstParameter;
        }
        else
        {
            return secondParameter;
        }
    }

    static char GetMax(char firstParameter, char secondParameter)
    {
        if (firstParameter > secondParameter)
        {
            return firstParameter;
        }
        else
        {
            return secondParameter;
        }
    }

    static string GetMax(string firstParameter, string secondParameter)
    {
        if (string.Compare(firstParameter, secondParameter) == 1)
        {
            return firstParameter;
        }
        else
        {
            return secondParameter;
        }
    }
}

