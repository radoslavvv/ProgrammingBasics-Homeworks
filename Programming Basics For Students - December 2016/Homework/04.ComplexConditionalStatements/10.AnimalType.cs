using System;
using System.Linq;

namespace AnimalType
{
    class AnimalType
    {
        static void Main()
        {
            string[] mammals = { "dog" };
            string[] reptiles = { "crocodile", "tortoise", "snake" };

            string input = Console.ReadLine();

            if (mammals.Contains(input))
            {
                Console.WriteLine("mammal");
            }
            else if (reptiles.Contains(input))
            {
                Console.WriteLine("reptile");
            }
            else
            {
                Console.WriteLine("unknown");
            }

        }
    }
}
