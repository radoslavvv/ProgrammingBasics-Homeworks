using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string command = Console.ReadLine();

        Dictionary<string,string> logins = new Dictionary<string, string>();
        while (command != "login")
        {
            string username = command.Split()[0];
            string pass = command.Split()[2];

            logins[username] = pass;

            command = Console.ReadLine();
        }

        command = Console.ReadLine();
        int failedLoginsCount = 0;
        while (command != "end")
        {
            string username = command.Split()[0];
            string pass = command.Split()[2];

            if (!logins.ContainsKey(username) || logins[username] != pass)
            {
                Console.WriteLine($"{username}: login failed");
                failedLoginsCount++;
            }
            else
            {
                Console.WriteLine($"{username}: logged in successfully");
            }
            command = Console.ReadLine();
        }
        Console.WriteLine($"unsuccessful login attempts: {failedLoginsCount}");
    }
}

