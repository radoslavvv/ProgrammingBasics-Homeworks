using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

class Program
{
    static void Main()
    {
        decimal lightYears = decimal.Parse(Console.ReadLine());

        decimal totalSecondsCount = (9450000000000m * lightYears)/ 300000m;
        TimeSpan timespan = TimeSpan.FromSeconds((long)Math.Round(totalSecondsCount,0));

        Console.WriteLine($"{timespan.Days / 7} weeks");
        Console.WriteLine($"{timespan.Days % 7} days");
        Console.WriteLine($"{timespan.Hours} hours");
        Console.WriteLine($"{timespan.Minutes} minutes");
        Console.WriteLine($"{timespan.Seconds} seconds");
    }
}

