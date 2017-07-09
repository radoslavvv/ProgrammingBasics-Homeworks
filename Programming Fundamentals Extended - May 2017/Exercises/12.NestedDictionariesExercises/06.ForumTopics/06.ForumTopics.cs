using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Dictionary<string, List<string>> topics = new Dictionary<string, List<string>>();

        string command = Console.ReadLine();

        while (command != "filter")
        {
            List<string> split = command.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToList();


            string currentTopic = split[0];
            List<string> currentTags = split[1].Split(',').Select(w => w.Trim()).Distinct().ToList();


            if (!topics.ContainsKey(currentTopic))
            {
                topics.Add(currentTopic, new List<string>());
            }
            topics[currentTopic].AddRange(currentTags);
            topics[currentTopic] = topics[currentTopic].Distinct().ToList();

            command = Console.ReadLine();
        }
        List<string> tags = Console.ReadLine().Split(',').Select(w => w.Trim()).ToList();

        foreach (var topic in topics)
        {
            if (!tags.Except(topic.Value).Any())
            {
                Console.Write($"{topic.Key}| ");
                for (int i = 0; i < topic.Value.Count; i++)
                {
                    if (i != topic.Value.Count - 1)
                    {
                        Console.Write($"#{topic.Value[i]}, ");
                    }
                    else
                    {
                        Console.WriteLine($"#{topic.Value[i]}");
                    }
                   
                }

            }
        }


    }
}

