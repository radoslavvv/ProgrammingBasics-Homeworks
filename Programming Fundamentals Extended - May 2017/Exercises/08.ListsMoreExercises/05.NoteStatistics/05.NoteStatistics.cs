using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        List<string> allnotes = new List<string>()
        {
            "C","C#","D","D#","E","F","F#","G","G#","A","A#","B"
        };

        List<double> frequencies = new List<double>()
        {
            261.63, 277.18, 293.66, 311.13, 329.63, 349.23, 369.99, 392.00, 415.30, 440.00, 466.16, 493.88
        };

        List<double> input = Console.ReadLine()
            .Split()
            .Select(double.Parse)
            .ToList();

        List<string> notes = new List<string>();
        List<string> naturals = new List<string>();
        List<string> sharps = new List<string>();

        double naturalsSum = 0;
        double sharpsSum = 0;

        for (int i = 0; i < input.Count; i++)
        {
            int index = frequencies.IndexOf(input[i]);
            string currentNote = allnotes[index];

            notes.Add(currentNote);
            if (currentNote.Contains("#"))
            {
                sharps.Add(currentNote);
                sharpsSum += input[i];
            }
            else
            {
                naturals.Add(currentNote);
                naturalsSum += input[i];
            }
        }
        Console.WriteLine($"Notes: {string.Join(" ",notes)}");
        Console.WriteLine($"Naturals: {string.Join(", ", naturals)}");
        Console.WriteLine($"Sharps: {string.Join(", ", sharps)}");
        Console.WriteLine($"Naturals sum: {string.Join(" ", naturalsSum)}");
        Console.WriteLine($"Sharps sum: {string.Join(" ", sharpsSum)}");

    }
}


