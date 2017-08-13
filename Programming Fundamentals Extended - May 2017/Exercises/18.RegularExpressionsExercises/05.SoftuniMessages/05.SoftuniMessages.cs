using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Regex regex = new Regex(@"(?<=^)([0-9]+)(.+)([0-9]+)");
        Regex wordRegex = new Regex(@"[A-Za-z]");
        Regex numbersRegex  = new Regex(@"\d");

        string input = Console.ReadLine();
        while (input != "Decrypt!")
        {
            string print = "";
            int lenght = int.Parse(Console.ReadLine());

            Match match = regex.Match(input);
            if (match.Success)
            {
                MatchCollection wordMatch = wordRegex.Matches(input);
                string[] word = wordMatch.Cast<Match>().Select(w=>w.Value).ToArray();

                MatchCollection numbersMatches = numbersRegex.Matches(input);
                int[] numbers = numbersMatches.Cast<Match>().Select(n => int.Parse(n.Value)).ToArray();
                if (word.Length > 0 && numbers.Length > 0)
                {
                    if (word.Length == lenght)
                    {
                        foreach (int num in numbers)
                        {
                            int number = int.Parse(num.ToString());

                            if (number >= 0 && number <= word.Length - 1)
                            {
                                print += word[number];
                            }
                        }
                        Console.WriteLine($"{string.Join("", word)} = {print}");
                    }
                } 
               
            }
            

            //Match middlePartRegex = wordRegex.Match(middlePart);
            //string middlePartText = middlePartRegex.Groups[0].Value;

          
            input = Console.ReadLine();
        }
        
    }
}

