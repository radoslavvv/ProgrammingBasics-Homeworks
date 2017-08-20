using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        List<string> lines = new List<string>();

        Regex regex = new Regex("<a.+=\"(?<site>.+)\">(?<name>.+)<\\/a>");

        while (input != "end")
        {
            lines.Add(input);
            input = Console.ReadLine();
        }
        
        foreach (var line in lines)
        {
            Match match = regex.Match(line);
            if (match.Success)
            {
                string site = match.Groups["site"].Value;
                string name = match.Groups["name"].Value;
                string replace = $"[URL href=\"{site}\"]{name}[/URL]";

                string result = regex.Replace(line, replace, 1);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(line);
            }
        }
    }
}

