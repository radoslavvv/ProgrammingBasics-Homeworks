using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        List<double> capacities = Console.ReadLine()
            .Split()
            .Select(double.Parse)
            .ToList();

        List<double> usagePerHour = Console.ReadLine()
            .Split()
            .Select(double.Parse)
            .ToList();

        List<double> result = capacities.ToList();
        int hoursCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < capacities.Count; i++)
        {
            bool isDead = false;
            for (int j = 1; j <= hoursCount; j++)
            {
                capacities[i] -= usagePerHour[i];
                if (capacities[i] <= 0)
                {
                    Console.WriteLine($"Battery {i+1}: dead (lasted {j} hours)");
                    isDead = true;
                    break;
                }
            }
            if (!isDead)
            {
                Console.WriteLine($"Battery {i + 1}: {capacities[i]:0.00} mAh ({(capacities[i] / result[i]) * 100:0.00})%");
            }      
        }
        
    }
}

