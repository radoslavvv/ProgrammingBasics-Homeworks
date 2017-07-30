using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string text = Console.ReadLine().Trim(new char[] { '[', ']' });
        string[] students = text.Split(new string[] { "}," }, StringSplitOptions.RemoveEmptyEntries);

        for (var index = 0; index < students.Length; index++)
        {
            string student = students[index]
                .Trim(new char[] { '[', '}' });

            string[] studentTokens = student
                .Split(new char[] { ':', '"', ',' }, StringSplitOptions.RemoveEmptyEntries);

            string name = studentTokens[1];
            int age = int.Parse(studentTokens[3]);
            List<int> grades = GetGrades(studentTokens);

            PrintResults(name, age, grades);
        }
    }

    private static void PrintResults(string name, int age, List<int> grades)
    {
        if (grades.Any())
        {
            Console.WriteLine($"{name} : {age} -> {string.Join(", ", grades)}");
        }
        else
        {
            Console.WriteLine($"{name} : {age} -> None");
        }
    }

    private static List<int> GetGrades(string[] tokens)
    {
        List<int> grades = new List<int>();
        if (string.Join("", tokens.Skip(5)) != "[]")
        {
            grades = tokens.Skip(5).Select(g => g.Trim(new char[] { '[', ']' })).Select(int.Parse).ToList();
        }

        return grades;
    }
}

