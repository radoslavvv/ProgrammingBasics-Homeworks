using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int photoNumber = int.Parse(Console.ReadLine());
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());
        int photoSize = int.Parse(Console.ReadLine());
        int witdh = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());
    
        if (witdh > height)
        {
            string oreantation = "landscape";
        }
        else if (witdh == height)
        {
            string oreantation = "square";
        }
        else
        {
            string oreantation = "portrait";
        }
       
        Console.WriteLine($"Name: DSC_{photoNumber:d4}.jpg");
        Console.WriteLine($"Date Taken: {day:00}/{month:00}/{year} {hours:00}:{minutes:00}");
        if (photoSize < 1000)
        {
            Console.WriteLine($"Size: {photoSize}B");
        }
        else if (photoSize > 1000000)
        {
            Console.WriteLine($"Size: {photoSize / 1000000.0}MB");
        }
        else if (photoSize > 1000)
        {
            Console.WriteLine($"Size: {photoSize/1000.0}KB");
        }
        Console.WriteLine($"Resolution: {witdh}x{height} ({oreantation})");

    }
}

