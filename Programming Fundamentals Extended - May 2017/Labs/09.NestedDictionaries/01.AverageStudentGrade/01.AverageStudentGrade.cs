using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AverageStudentGrade
{
    static void Main()
    {
        int linesCount = int.Parse(Console.ReadLine());
        var grades = new Dictionary<string, List<double>>();

        for (int i = 0; i < linesCount; i++)
        {
            string input = Console.ReadLine();
            string name = input.Split()[0];
            double grade = double.Parse(input.Split()[1]);

            if (!grades.ContainsKey(name))
            {
                grades.Add(name, new List<double>());
            }
            grades[name].Add(grade);
        }
        foreach (var person in grades)
        {
            Console.Write($"{person.Key} -> ");
            foreach (var grade in person.Value)
            {
                Console.Write($"{grade:0.00} ");
            }
            Console.WriteLine($"(avg: {person.Value.Average():0.00})");
        }
    }
}

