using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Dictionary<string,int> ages = new Dictionary<string, int>();
        Dictionary<string,string> positions = new Dictionary<string, string>();
        Dictionary<string,double> salaries = new Dictionary<string, double>();

        string command = Console.ReadLine();
        while (command != "filter base")
        {
            string[] split = command.Split();
            string name = split[0];
            double value;
            int secondValue;

            if (int.TryParse(split[2], out secondValue))
            { 
                ages[name]= secondValue;
            }
            else if (double.TryParse(split[2], out value))
            {
                salaries[name] = value;
            }
            else
            {
                positions[name]= split[2];
            }
            command = Console.ReadLine();
        }
        string searched = Console.ReadLine();

        if (searched == "Salary")
        {
            foreach (var salary in salaries)
            {
                Console.WriteLine($"Name: {salary.Key}");
                Console.WriteLine($"Salary: {salary.Value:0.00}");
                Console.WriteLine(new string('=', 20));
            }
        }
        else if (searched == "Age")
        {
            foreach (var age in ages)
            {
                Console.WriteLine($"Name: {age.Key}");
                Console.WriteLine($"Age: {age.Value}");
                Console.WriteLine(new string('=', 20));
            }
        }
        else if (searched == "Position")
        {
            foreach (var position in positions)
            {
                Console.WriteLine($"Name: {position.Key}");
                Console.WriteLine($"Position: {position.Value}");
                Console.WriteLine(new string('=', 20));
            }
        }
    }
}


