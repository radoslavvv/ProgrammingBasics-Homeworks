using System;

namespace VolleyBall
{
    class VolleyBall
    {
        static void Main()
        {
            string yearType = Console.ReadLine();
            int celebrations = int.Parse(Console.ReadLine());
            int weekendsToHomeTown = int.Parse(Console.ReadLine());

            double weekendsCount = 48;

            double playsInSofia = (weekendsCount - weekendsToHomeTown) * 3.0 / 4.0;
            double playsInHomeTown = weekendsToHomeTown;
            double playsInSofiaAtCelebration = celebrations * 2.0 / 3.0;

            double totalPlays = playsInSofia + playsInSofiaAtCelebration + playsInHomeTown;

            if (yearType.Equals("leap"))
            {
                totalPlays += totalPlays * 0.15;
            }
            Console.WriteLine("{0}", Math.Floor(totalPlays));
        }
    }
}
