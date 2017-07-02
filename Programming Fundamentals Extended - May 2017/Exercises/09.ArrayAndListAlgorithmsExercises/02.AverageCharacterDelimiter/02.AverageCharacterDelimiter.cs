using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        string[] characters = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

        double totalSum = 0;
        int totalLetters = 0;

        foreach (var character in characters)
        {
            for (int i = 0; i < character.Length; i++)
            {
                totalSum += character[i];
                totalLetters++;
            }
        }
        totalSum = Math.Floor(totalSum / totalLetters);
        string delimiter = ((char)totalSum).ToString().ToUpper();

        Console.WriteLine($"{string.Join(delimiter,characters)}");

    }
}

