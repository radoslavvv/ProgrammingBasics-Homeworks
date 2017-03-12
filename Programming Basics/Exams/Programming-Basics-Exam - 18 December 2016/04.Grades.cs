using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudends = int.Parse(Console.ReadLine());
            int between3and4 = 0;
            int between4and5 = 0;
            int between5and6 = 0;
            int between2and3 = 0;
            decimal gradesSum = 0;
            for (int i = 0; i < numberOfStudends; i++)
            {
                decimal grade = decimal.Parse(Console.ReadLine());
                gradesSum += grade;

                if (grade <= 2.99m)
                {
                    between2and3++;
                }
                else if (grade >= 3.00m && grade <= 3.99m)
                {
                    between3and4++;
                }
                else if (grade >= 4.00m && grade <= 4.99m)
                {
                    between4and5++;
                }
                else
                {
                    between5and6++;
                }

                
            }
            Console.WriteLine("Top students: {0:0.00}%", (100m * between5and6) / numberOfStudends);
            Console.WriteLine("Between 4.00 and 4.99: {0:0.00}%", (100m * between4and5) / numberOfStudends);
            Console.WriteLine("Between 3.00 and 3.99: {0:0.00}%", (100m * between3and4) / numberOfStudends);
            Console.WriteLine("Fail: {0:0.00}%", (100m * between2and3) / numberOfStudends);
            Console.WriteLine("Average: {0:0.00}", gradesSum / numberOfStudends);

        }
    }
}
