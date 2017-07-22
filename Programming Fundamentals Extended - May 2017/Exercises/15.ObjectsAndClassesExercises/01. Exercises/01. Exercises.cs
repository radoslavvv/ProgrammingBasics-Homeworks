using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Exercise
{
    public string Topic { get; set; }
    public string CourseName { get; set; }
    public string JudgeLink { get; set; }
    public List<string> Problems { get; set; }
}

class Program
{
    static void Main()
    {
        string command = Console.ReadLine();
        List<Exercise> exercises = new List<Exercise>();

        while (command != "go go go")
        {
            List<string> tokens = command
                .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string topic = tokens[0];
            string courseName = tokens[1];
            string link = tokens[2];
            List<string> problems = tokens[3].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(p => p.Trim()).ToList();

            Exercise exercise = new Exercise()
            {
                Topic = topic,
                CourseName = courseName,
                JudgeLink = link,
                Problems = problems.ToList()
            };

            exercises.Add(exercise);
            command = Console.ReadLine();
        }

        foreach (var exercise in exercises)
        {
            Console.WriteLine($"Exercises: {exercise.Topic}");
            Console.WriteLine($"Problems for exercises and homework for the \"{exercise.CourseName}\" course @ SoftUni.");
            Console.WriteLine($"Check your solutions here: {exercise.JudgeLink}");

            int index = 1;
            foreach (var problem in exercise.Problems)
            {
                Console.WriteLine($"{index}. {problem}");
                index++;
            }
        }

    }
}

