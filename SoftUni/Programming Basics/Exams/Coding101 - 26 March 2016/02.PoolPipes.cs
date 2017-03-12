using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PoolPipes
{
    class Program
    {
        static void Main(string[] args)
        {
            double poolVolume = double.Parse(Console.ReadLine());
            double firstPipeVolume = double.Parse(Console.ReadLine());
            double secondPipeVolume = double.Parse(Console.ReadLine());
            double offHours = double.Parse(Console.ReadLine());

            double firstPipeFill = firstPipeVolume * offHours;
            double secondPipeFill = secondPipeVolume * offHours;
            double totalFill = firstPipeFill + secondPipeFill;

            if (totalFill > poolVolume)
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", offHours,totalFill-poolVolume);
            }
            else if(totalFill <=poolVolume)
            {
                int poolPercentage = (int)((totalFill / poolVolume) * 100);
                int firstPipePercentage = (int)((firstPipeFill / totalFill) * 100);
                int secondPipePercentage = (int)((secondPipeFill / totalFill) * 100);

                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", poolPercentage, firstPipePercentage, secondPipePercentage);
            }

        }
    }
}
