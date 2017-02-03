using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessThePassword
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (input != "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Wrong password!");
            }
            else
            {
                Console.WriteLine("Welcome");
            }
        }
    }
}
