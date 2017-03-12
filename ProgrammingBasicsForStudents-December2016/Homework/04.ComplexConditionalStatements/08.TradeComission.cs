using System;
using System.Linq;

namespace ComplexConditionals
{
    class ComplexConditionals
    {
        static void Main()
        {
            string city = Console.ReadLine();
            double money = double.Parse(Console.ReadLine());
            string[] cities = { "Sofia", "Varna", "Plovdiv" };

            if (cities.Contains(city) && money >= 0)
            {
                if (money >= 0 && money <= 500 && money >= 0)
                {
                    if (city.Equals("Sofia"))
                    {
                        Console.WriteLine("{0:0.00}", money * 0.05);
                    }
                    else if (city.Equals("Varna"))
                    {
                        Console.WriteLine("{0:0.00}", money * 0.045);
                    }
                    else if (city.Equals("Plovdiv"))
                    {
                        Console.WriteLine("{0:0.00}", money * 0.055);
                    }
                }
                else if (money > 500 && money <= 1000)
                {
                    if (city.Equals("Sofia"))
                    {
                        Console.WriteLine("{0:0.00}", money * 0.07);
                    }
                    else if (city.Equals("Varna"))
                    {
                        Console.WriteLine("{0:0.00}", money * 0.075);
                    }
                    else if (city.Equals("Plovdiv"))
                    {
                        Console.WriteLine("{0:0.00}", money * 0.08);
                    }
                }
                else if (money > 100 && money <= 10000)
                {
                    if (city.Equals("Sofia"))
                    {
                        Console.WriteLine("{0:0.00}", money * 0.08);
                    }
                    else if (city.Equals("Varna"))
                    {
                        Console.WriteLine("{0:0.00}", money * 0.10);
                    }
                    else if (city.Equals("Plovdiv"))
                    {
                        Console.WriteLine("{0:0.00}", money * 0.12);
                    }
                }
                else if (money > 10000)
                {
                    if (city.Equals("Sofia"))
                    {
                        Console.WriteLine("{0:0.00}", money * 0.12);
                    }
                    else if (city.Equals("Varna"))
                    {
                        Console.WriteLine("{0:0.00}", money * 0.13);
                    }
                    else if (city.Equals("Plovdiv"))
                    {
                        Console.WriteLine("{0:0.00}", money * 0.145);
                    }
                }
            }
            else
            {
                Console.WriteLine("error");
            }

        }
    }
}
