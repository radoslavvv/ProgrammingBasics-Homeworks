using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Dictionary<string, int> count = new Dictionary<string, int>();

        StreamReader reader = new StreamReader("words.txt");
        List<string> searchedWords = reader.ReadLine().Split().ToList();


        reader = new StreamReader("text.txt");
        while (true)
        {
            string line = reader.ReadLine();
            if (line == null) break;

            string[] sentense = line.ToLower().Split(new char[] { ',', '.', '?', '!', '-', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            CountWords(searchedWords, count, sentense);

        }
        StreamWriter writer = new StreamWriter("output.txt", append: true);

        WriteResults(count, writer);

        writer.Close();
        reader.Close();

    }

    private static void WriteResults(Dictionary<string, int> count, StreamWriter writer)
    {
        foreach (var word in count.OrderByDescending(w => w.Value))
        {
            writer.WriteLine($"{word.Key} - {word.Value}");
        }
    }

    private static void CountWords(List<string> searchedWords, Dictionary<string, int> count, string[] sentense)
    {
        foreach (string word in sentense)
        {
            if (searchedWords.Contains(word))
            {
                if (!count.ContainsKey(word))
                {
                    count.Add(word, 0);
                }
                count[word]++;
            }
        }
    }
}

