using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DaysAfterBirth
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            DateTime date = DateTime.ParseExact(input, dd-MM-yyyy, CultureInfo.InvariantCulture);

            Console.WriteLine({0dd-MM-yyyy}, date.AddDays(999));
        }
    }
}
