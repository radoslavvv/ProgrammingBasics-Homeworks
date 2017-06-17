using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        char[] firstLine = Console.ReadLine().ToCharArray();
        int[] secondLine = Console.ReadLine().Split().Select(int.Parse).ToArray();

        for (int i = 0; i < secondLine.Length; i++)
        {
            if (secondLine[i] % 2 == 0)
            {
                firstLine[i] = (char) (firstLine[i] - secondLine[i]);
            }
            else
            {
                firstLine[i] = (char) (firstLine[i] + secondLine[i]);
            }
        }
        Console.WriteLine(String.Join("",firstLine));
    }
}

