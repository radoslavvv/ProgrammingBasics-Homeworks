using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int pairsCount = int.Parse(Console.ReadLine());

            int previousPairSum = 0;

            int maxDiff = int.MinValue;
            bool hasDiff = false;

            for (int i = 0; i < pairsCount; i++)
            {
                int currentPairOne = int.Parse(Console.ReadLine());
                int currentPairTwo = int.Parse(Console.ReadLine());
                int currentPairSum = currentPairOne + currentPairTwo;

                if (i == 0)
                {
                    previousPairSum = currentPairSum;
                    continue;
                }
                else
                {
                    if (currentPairSum != previousPairSum)
                    {
                        hasDiff = true;
                        int diff = Math.Abs(currentPairSum - previousPairSum);

                        if (diff > maxDiff)
                        {
                            maxDiff = diff;
                        }
                    }
                }
                previousPairSum = currentPairSum;
            }

            if (hasDiff)
            {
                Console.WriteLine("No, maxdiff = {0}", maxDiff);
            }
            else
            {
                Console.WriteLine("Yes, value = {0}", previousPairSum);
            }
        }

    }
}


