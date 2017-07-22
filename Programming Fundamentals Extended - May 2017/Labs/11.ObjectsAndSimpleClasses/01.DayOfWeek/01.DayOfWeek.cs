using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        DateTime date = DateTime.ParseExact(Console.ReadLine(),"d-M-yyyy",CultureInfo.InvariantCulture);

        Console.WriteLine(date.DayOfWeek);
    }
}

