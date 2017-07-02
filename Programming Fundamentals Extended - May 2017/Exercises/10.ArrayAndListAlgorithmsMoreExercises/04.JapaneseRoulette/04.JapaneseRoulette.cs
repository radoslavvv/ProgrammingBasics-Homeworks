using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int[] cylinder = Console.ReadLine()
            .Split(new char[] { ' '},StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        string[] players = Console.ReadLine()
            .Split();

        int bulletIndex = FindBulletIndex(cylinder);

        bool oneIsDead = false;
        int player = 0;

        while (player < players.Count())
        {
            string[] currentPlayer = players[player]
                .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            int power = int.Parse(currentPlayer[0]);
            string direction = currentPlayer[1];

            if (direction == "Right")
            {
                while (power > 0)
                {
                    power--;
                    bulletIndex++;
                    if(bulletIndex > 5)
                    {
                        bulletIndex = 0;
                    }
                }
               // bulletIndex = (bulletIndex + power) % 6;
            }
            else if (direction == "Left")
            {
                while(power > 0)
                {
                    power--;
                    bulletIndex--;
                    if(bulletIndex < 0)
                    {
                        bulletIndex = 5;
                    }
                }
                //bulletIndex = Math.Abs(bulletIndex - power) % 6;
                //if(bulletIndex < 0)
                //{
                //    bulletIndex += 6;
                //}
            }

            if (bulletIndex == 2)
            {
                Console.WriteLine($"Game over! Player {player} is dead.");
                oneIsDead = true;
                break;
            }

            player++;
            bulletIndex = (bulletIndex + 1) % 6;
        }

        if (!oneIsDead)
        {
            Console.WriteLine("Everybody got lucky!");
        }
    }

    private static int FindBulletIndex(int[] gun)
    {
        for (int i = 0; i < gun.Length; i++)
        {
            if (gun[i] == 1)
            {
                return i;
            }
        }
        return 0;
    }
}   