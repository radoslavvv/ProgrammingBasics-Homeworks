using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());

        if (end - start < 5)
        {
            Console.WriteLine("No");
        }
        else
        {
            for (int first = start; first < end; first++)
            {
                for (int second = first + 1; second < end; second++)
                {
                    for (int third = second + 1; third < end; third++)
                    {
                        for (int fourth = third + 1; fourth <= end; fourth++)
                        {
                            for (int fifth = fourth + 1; fifth <= end; fifth++)
                            {
                                Console.WriteLine($"{first} {second} {third} {fourth} {fifth}");
                            }
                        }
                    }
                }
            }
        }
    }
}

