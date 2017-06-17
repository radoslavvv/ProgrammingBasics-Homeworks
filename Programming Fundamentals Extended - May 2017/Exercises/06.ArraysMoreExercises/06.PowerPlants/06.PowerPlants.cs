using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int[] plants = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int totalDays = 0;
        int daysCount = 0;
        int seasonsCount = 0;
        while (true)
        {
            if (plants.Any(p => p > 0))
            {
                for (int i = 0; i < plants.Length; i++)
                {
                    if (plants[i] > 0)
                    {
                        plants[i]--;
                        if (i == daysCount)
                        {
                            plants[i]++;
                        }
                    }
                }
                totalDays++;
                daysCount++;
                if (plants.Any(p => p > 0) && daysCount == plants.Length)
                {
                    seasonsCount++;
                    daysCount = 0;
                    for (int i = 0; i < plants.Length; i++)
                    {
                        if (plants[i] > 0)
                        {
                            plants[i]++;
                        }
                    }
                }
                

            }
            else
            {
                if (seasonsCount == 1)
                {
                    Console.WriteLine($"survived {totalDays} days ({seasonsCount} season)");
                    break;
                }
                else
                {
                    Console.WriteLine($"survived {totalDays} days ({seasonsCount} seasons)");
                    break;
                }
                
            }          
        }
       
    }
}

