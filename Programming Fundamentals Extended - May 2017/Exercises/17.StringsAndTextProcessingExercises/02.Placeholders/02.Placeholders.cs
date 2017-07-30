using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        while (input != "end")
        {
            string[] split = input
                .Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(w => w.Trim())
                .ToArray();

            string message = RemoveForbidenCharacters(split);

            Console.WriteLine(message);

            input = Console.ReadLine();
        }

    }

    private static string RemoveForbidenCharacters(string[] split)
    {
        string message = split[0];
        string[] placeholders = split[1].Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);


        for (int i = 0; i < placeholders.Length; i++)
        {
            message = message.Replace($@"{{{i}}}", placeholders[i]);
        }

        return message;
    }
}

