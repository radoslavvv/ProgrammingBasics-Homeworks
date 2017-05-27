using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CharacterStats
{
    static void Main()
    {
        string name = Console.ReadLine();
        int currHealth = int.Parse(Console.ReadLine());
        int maxHealth = int.Parse(Console.ReadLine());
        int currEnergy = int.Parse(Console.ReadLine());
        int maxEnergy = int.Parse(Console.ReadLine());

        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Health: |{new string('|', currHealth)}{new string('.',maxHealth-currHealth)}|");
        Console.WriteLine($"Energy: |{new string('|', currEnergy)}{new string('.', maxEnergy - currEnergy)}|");
    }
}

