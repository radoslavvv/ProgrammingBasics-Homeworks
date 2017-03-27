using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Battles
{
    static void Main()
    {
        int firstPlayerPokemons = int.Parse(Console.ReadLine());
        int secondPlayerPokemons = int.Parse(Console.ReadLine());
        int maxBattlesCount = int.Parse(Console.ReadLine());

        int battlesCount = 0;

        for (int i = 1; i <= firstPlayerPokemons; i++)
        {
            for (int a = 1; a <= secondPlayerPokemons && battlesCount < maxBattlesCount; a++)
            {
                Console.Write("({0} <-> {1}) ", i, a);
                battlesCount++;
            }
        }
    }
}

