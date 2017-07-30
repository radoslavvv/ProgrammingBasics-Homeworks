using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public List<int> Grades { get; set; }
}


class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();

        string input = Console.ReadLine();
        while (input != "stringify")
        {
            string[] split = input.Split(new char[] { ':', ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

            string name = split[0];
            int age = int.Parse(split[1]);
            List<int> grades = GetGrades(input);

            Student currentStudent = new Student()
            {
                Name = name,
                Age = age,
                Grades = grades
            };

            students.Add(currentStudent);

            input = Console.ReadLine();
        }

        PrintResult(students);
    }

    private static void PrintResult(List<Student> students)
    {
        Console.Write("[");
        int index = 0;
        foreach (var student in students)
        {
            index++;
            if (index < students.Count)
            {
                Console.Write(
                    $"{{name:\"{student.Name}\",age:{student.Age},grades:[{string.Join(", ", student.Grades)}]}},");
            }
            else
            {
                Console.Write($"{{name:\"{student.Name}\",age:{student.Age},grades:[{string.Join(", ", student.Grades)}]}}");
            }

        }
        Console.WriteLine("]");
    }

    private static List<int> GetGrades(string input)
    {
        List<int> grades = new List<int>();

        if (input.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries).Length > 1)
        {
            grades = input.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries)[1]
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
        }
        else
        {
            grades = new List<int>();
        }

        return grades;
    }
}

