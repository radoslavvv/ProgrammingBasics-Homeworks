using System;

namespace Cinema
{
    class Cinema
    {
        static void Main()
        {
            string movieType = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int collums = int.Parse(Console.ReadLine());

            int seats = rows * collums;

            switch (movieType)
            {
                case "Premiere":
                    Console.WriteLine("{0:0.00} leva", seats * 12);
                    break;
                case "Normal":
                    Console.WriteLine("{0:0.00} leva", seats * 7.50);
                    break;
                case "Discount":
                    Console.WriteLine("{0:0.00} leva", seats * 5);
                    break;
            }
        }
    }
}
