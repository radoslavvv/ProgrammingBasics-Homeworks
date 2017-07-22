using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        List<string> text = Console.ReadLine().Split().ToList();

        Random random = new Random();

        for (int i = 0; i < text.Count; i++)
        {
            int randomValue = random.Next(0, text.Count - 1);

            string temp = text[i];
            text[i] = text[randomValue];
            text[randomValue] = temp;
        }

        foreach (var word in text)
        {
            Console.WriteLine(word);
        }
    }
}

