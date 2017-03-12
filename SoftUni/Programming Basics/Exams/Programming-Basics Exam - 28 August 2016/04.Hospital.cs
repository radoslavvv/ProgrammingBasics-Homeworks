using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());
            int doctors = 7;

            int looked = 0;
            int notLooked = 0;

            for (int i = 1; i <= period; i++)
            {
                int patients = int.Parse(Console.ReadLine());

                if (i % 3 == 0)
                {
                    if (looked < notLooked)
                    {
                        doctors++;
                    }
                }

                if (patients - doctors > 0)
                {
                    notLooked += patients - doctors;
                    looked += doctors;
                }
                else
                {
                    looked += patients;
                }

            }
              Console.WriteLine("Treated patients: {0}.",looked);
            Console.WriteLine("Untreated patients: {0}.", notLooked);
        }
    }
}
