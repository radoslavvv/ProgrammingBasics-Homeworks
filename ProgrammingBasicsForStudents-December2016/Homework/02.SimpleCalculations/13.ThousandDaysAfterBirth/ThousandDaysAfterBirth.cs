using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

class ThousandDaysAfterBirth
{
    static void Main()
    {
        string input = Console.ReadLine();
        DateTime date = DateTime.ParseExact(input, "dd-MM-yyyy", CultureInfo.InvariantCulture);

        Console.WriteLine("{0:dd-MM-yyyy}", date.AddDays(999));
    }
}

