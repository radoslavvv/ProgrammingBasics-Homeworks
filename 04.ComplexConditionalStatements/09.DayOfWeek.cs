using System;

namespace DayOfWeek
{
    class DayOfWeek
    {
        static void Main()
        {
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday", "Error" };
            int input = int.Parse(Console.ReadLine());
            if (input >= 1 && input <= 7)
            {
                Console.WriteLine("{0}", days[input - 1]);
            }
            else
            {

                Console.WriteLine("{0}", days[7]);
            }

        }
    }
}
