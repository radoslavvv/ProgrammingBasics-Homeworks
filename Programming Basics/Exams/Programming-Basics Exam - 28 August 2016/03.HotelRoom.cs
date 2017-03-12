using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            decimal studioPrice = 0;
            decimal apartmentPrice = 0;

            if(month == "May" || month == "October")
            {
                studioPrice = nights * 50;
                apartmentPrice = nights * 65;

                if (nights > 14)
                {
                    studioPrice -= studioPrice * 0.30m;
                }
                else if (nights > 7)
                {
                    studioPrice -= studioPrice * 0.05m;

                }
                

            }
            else if(month == "June" || month == "September")
            {
                studioPrice = nights * 75.20m;
                apartmentPrice = nights * 68.70m;

                if(nights > 14)
                {
                    studioPrice -= studioPrice * 0.20m;
                }

            }
            else if(month == "July" || month == "August")
            {
                studioPrice = nights * 76m;
                apartmentPrice = nights * 77m;
            }
            if(nights > 14)
            {
                apartmentPrice -= apartmentPrice * 0.10m;

            }
            Console.WriteLine("Apartment: {0:0.00} lv.", apartmentPrice);
            Console.WriteLine("Studio: {0:0.00} lv.",studioPrice);
        }
    }
}
