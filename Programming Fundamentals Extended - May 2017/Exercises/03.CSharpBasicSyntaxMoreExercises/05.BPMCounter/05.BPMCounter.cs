using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int bpm = int.Parse(Console.ReadLine());
        double beatsCount = double.Parse(Console.ReadLine());

        double barsCount = Math.Round((beatsCount / 4.0),1);
        int secondsCount = (int)((beatsCount / bpm) * 60);
        int minutesCount = secondsCount / 60;
        int seconds = secondsCount % 60;

        Console.WriteLine($"{barsCount} bars - {minutesCount}m {seconds}s");
    }
}

