using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Dictionary<string,int> values = new Dictionary<string, int>();

        string command = Console.ReadLine();
        while (command != "end")
        {
            string[] split = command.Split();

            int num = 0;
            if (int.TryParse(split[2], out num))
            {
                int value = int.Parse(split[2]);
                string entry = split[0];

                values[entry] = value;
            }
            else
            {
                string firstEntry = split[0];
                string secondEntry = split[2];

                if (values.ContainsKey(secondEntry))
                {
                    values[firstEntry] = values[secondEntry];
                }
            }
            command = Console.ReadLine();
        }

        foreach (var entry in values)
        {
            Console.WriteLine($"{entry.Key} === {entry.Value}");
        }
    }
}

