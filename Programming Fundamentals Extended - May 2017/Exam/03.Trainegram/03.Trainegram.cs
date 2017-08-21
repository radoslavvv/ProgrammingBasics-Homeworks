using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Regex regex = new Regex(@"(?<=^)(\<\[[^A-Za-z0-9<]*\]\.)(\.\[[A-Za-z0-9]*\]\.)*(?=$)");

        string input = Console.ReadLine();
        while (input != "Traincode!")
        {
            Match match = regex.Match(input);
            if (match.Success && match.Value != "")
            {
                Console.WriteLine(match.Value);
            }
            input = Console.ReadLine();
        }
    }
}

