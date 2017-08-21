using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        double technicalTeamMoney = 0;
        double theorecticalTeamMoney = 0;
        double practicalTeamMoney = 0;

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            long distance = long.Parse(Console.ReadLine());
            double cargoWeight = double.Parse(Console.ReadLine());
            string teamName = Console.ReadLine();

            distance *= 1600;
            cargoWeight *= 1000;

            double earnedMoney = (cargoWeight * 1.5) - (0.7 * distance * 2.5);

            switch (teamName)
            {
                case "Theoretical":
                    theorecticalTeamMoney += earnedMoney;
                    break;
                case "Technical":
                    technicalTeamMoney += earnedMoney;
                    break;
                case "Practical":
                    practicalTeamMoney += earnedMoney;
                    break;
            }
        }
        PrintResult(technicalTeamMoney, theorecticalTeamMoney, practicalTeamMoney);
    }

    private static void PrintResult(double technicalTeam, double theorecticalTeam, double practicalTeam)
    {
        if (technicalTeam > theorecticalTeam && technicalTeam > practicalTeam)
        {
            Console.WriteLine($"The Technical Trainers win with ${technicalTeam:0.000}.");
        }
        else if (theorecticalTeam > technicalTeam && theorecticalTeam > practicalTeam)
        {
            Console.WriteLine($"The Theoretical Trainers win with ${theorecticalTeam:0.000}.");
        }
        else if (practicalTeam > technicalTeam && practicalTeam > theorecticalTeam)
        {
            Console.WriteLine($"The Practical Trainers win with ${practicalTeam:0.000}.");
        }
    }
}

