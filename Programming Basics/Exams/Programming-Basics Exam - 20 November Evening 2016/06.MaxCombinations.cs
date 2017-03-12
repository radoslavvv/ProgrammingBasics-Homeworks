using System;

namespace MaxCombinations
{
    class MaxCombinations
    {
        static void Main()
        {
            int intervalBegining = int.Parse(Console.ReadLine());
            int intervalEnding = int.Parse(Console.ReadLine());
            int maximalCombinationsCount = int.Parse(Console.ReadLine());
            int combinations = 0;
            
            for (int i = intervalBegining; i <= intervalEnding; i++)
            {
                for (int a = intervalBegining; a <= intervalEnding && combinations < maximalCombinationsCount; a++)
                {
                    Console.Write("<{0}-{1}>",i,a);
                    combinations++;
                }
            }
        }
    }
}
