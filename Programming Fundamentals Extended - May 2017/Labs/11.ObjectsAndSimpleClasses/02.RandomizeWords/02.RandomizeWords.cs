using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string[] words = Console.ReadLine().Split();

        Random random = new Random();

        for (int i = 0; i < words.Length; i++)
        {
            int nextIndex = random.Next(0, words.Length);
            string temp = words[i];
            words[i] = words[nextIndex];
            words[nextIndex] = temp;
        }
        foreach (var word in words)
        {
            Console.WriteLine(word);
        }
    }
}

