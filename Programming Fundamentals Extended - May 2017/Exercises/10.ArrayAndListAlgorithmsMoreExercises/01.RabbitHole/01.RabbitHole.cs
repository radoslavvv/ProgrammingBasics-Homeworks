using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        List<string> input = Console.ReadLine()
            .Split()
            .ToList();

        int energy = int.Parse(Console.ReadLine());

        int i = 0;

        while (true)
        {
            if (input[i] == "RabbitHole")
            {
                Console.WriteLine("You have 5 years to save Kennedy!");
                break;
            }
            else
            {
                string[] split = input[i].Split('|');
                //Left | 10
                string action = split[0];
                int value = int.Parse(split[1]);

                if (action == "Bomb")
                {
                    energy -= value;
                    input.RemoveAt(i);
                    if (energy <= 0)
                    {
                        Console.WriteLine("You are dead due to bomb explosion!");
                        break;
                    }
                }
                else if (action == "Left")
                {
                    i -= value % input.Count;
                    if(i < 0)
                    {
                        i = Math.Abs(i) % input.Count;
                    }
                    energy -= value;
                }
                else if (action == "Right")
                {
                    MoveRight(input, ref energy, ref i, value);
                }

                if (input[input.Count - 1] == "RabbitHole")
                {
                    input.Add($"Bomb|{energy}");
                }
                else
                {
                    input[input.Count - 1] = $"Bomb|{energy}";
                }

                if(energy <= 0)
                {
                    Console.WriteLine("You are tired. You can't continue the mission.");
                    break;
                }
            }
        }

    }

    private static void MoveRight(List<string> input, ref int energy, ref int i, int value)
    {
        i += value % input.Count;
        energy -= value;
    }
}

