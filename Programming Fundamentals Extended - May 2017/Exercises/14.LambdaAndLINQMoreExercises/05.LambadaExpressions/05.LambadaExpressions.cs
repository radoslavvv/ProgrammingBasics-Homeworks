using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Dictionary<string, string> values = new Dictionary<string, string>();

        string input = Console.ReadLine();
        while (input != "lambada")
        {
            string[] split = input.Split(new string[] { " => " }, StringSplitOptions.RemoveEmptyEntries);

            if (split[0] == "dance")
            {
                values = Dance(values);
            }
            else
            {
                AddValue(values, split);
            }
            input = Console.ReadLine();
        }
        PrintResult(values);
    }

    private static void AddValue(Dictionary<string, string> values, string[] split)
    {
        string key = split[0];
        string value = split[1];

        values[key] = value;
    }

    private static Dictionary<string, string> Dance(Dictionary<string, string> values)
    {
        values = values.ToDictionary(v => v.Key, v => v.Key + "." + v.Value);
        return values;
    }

    private static void PrintResult(Dictionary<string, string> values)
    {
        foreach (var expression in values)
        {
            Console.WriteLine($"{expression.Key} => {expression.Value}");
        }
    }
}

