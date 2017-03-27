using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Vacation
{
    static void Main()
    {
        int elderPeopleCount = int.Parse(Console.ReadLine());
        int studentsCount = int.Parse(Console.ReadLine());
        int nightsCount = int.Parse(Console.ReadLine());
        string transportType = Console.ReadLine();

        decimal totalPrice = 0;

        if (transportType == "train")
        {
            totalPrice += elderPeopleCount * 24.99m;
            totalPrice += studentsCount * 14.99m;
            if (elderPeopleCount + studentsCount >= 50)
            {
                totalPrice /= 2;
            }
        }
        else if (transportType == "bus")
        {
            totalPrice += elderPeopleCount * 32.50m;
            totalPrice += studentsCount * 28.50m;
        }
        else if (transportType == "boat")
        {
            totalPrice += elderPeopleCount * 42.99m;
            totalPrice += studentsCount * 39.99m;
        }
        else if (transportType == "airplane")
        {
            totalPrice += elderPeopleCount * 70.00m;
            totalPrice += studentsCount * 50.00m;
        }
        totalPrice *= 2;
        totalPrice += nightsCount * 82.99m;
        totalPrice += totalPrice * 0.10m;

        Console.WriteLine("{0:0.00}", totalPrice);
    }
}

