using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

class Website
{
    public string Host { get; set; }
    public string Domain { get; set; }
    public List<string> Queries { get; set; }
}

class Program
{
    static void Main()
    {
        List<Website> websites = new List<Website>();

        string command = Console.ReadLine();

        while (command != "end")
        {
            string[] tokens = command.Split(new string[]{" | "},StringSplitOptions.RemoveEmptyEntries);

            string host = tokens[0];
            string domain = tokens[1];
            List<string> queries = new List<string>();
            if (tokens.Length == 3)
            {
                queries = tokens[2].Split(new char[] {','}, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
            }
            Website website = new Website()
            {
                Host = host,
                Domain = domain
            };

            if (queries.Any())
            {
                website.Queries = queries.ToList();
            }
            else
            {
                website.Queries = new List<string>();
            }

            websites.Add(website);

            command = Console.ReadLine();
        }

        foreach (var website in websites)
        {
            if (website.Queries.Any())
            {
                Console.Write($"https://www.{website.Host}.{website.Domain}/query?=");
                for (int i = 0; i < website.Queries.Count; i++)
                {
                    if (i != website.Queries.Count - 1)
                    {
                        Console.Write($"[{website.Queries[i]}]&");
                    }
                    else
                    {
                        Console.Write($"[{website.Queries[i]}]");
                    }
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"https://www.{website.Host}.{website.Domain}");
            }
        }
    }
}

