using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding101Exam_26March2016
{
    class Program
    {
        static void Main(string[] args)
        {
            double oneKiloVegetables = double.Parse(Console.ReadLine());
            double oneKiloFruits = double.Parse(Console.ReadLine());

            int vegetablesKilograms = int.Parse(Console.ReadLine());
            int fruitsKilograms = int.Parse(Console.ReadLine());

            double vegetablesPrice = oneKiloVegetables * vegetablesKilograms;
            double fruitsPrice = oneKiloFruits * fruitsKilograms;
            double totalPrice = vegetablesPrice + fruitsPrice;

            Console.WriteLine("{0}", totalPrice / 1.94);
        }
    }
}
