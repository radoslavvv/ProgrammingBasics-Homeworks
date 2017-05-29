using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int counter = 1;

        int peshoDamage = int.Parse(Console.ReadLine());
        int goshoDamage = int.Parse(Console.ReadLine());

        int peshoHealth = 100;
        int goshoHealth = 100;

        while (true)
        {
            if (counter % 2 == 0)
            {
                peshoHealth -= goshoDamage;
                if (peshoHealth <= 0)
                {
                    break;
                }
                Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
            }
            else
            {
                goshoHealth -= peshoDamage;
                if (goshoHealth <= 0)
                {
                    break;
                }
                Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
            }
            if (counter % 3 == 0)
            {
                goshoHealth += 10;
                peshoHealth += 10;
            }
            counter++;
        }
        if (goshoHealth > 0)
        {
            Console.WriteLine($"Gosho won in {counter}th round.");
        }
        else if(peshoHealth > 0)
        {
            Console.WriteLine($"Pesho won in {counter}th round.");
        }
    }
}

