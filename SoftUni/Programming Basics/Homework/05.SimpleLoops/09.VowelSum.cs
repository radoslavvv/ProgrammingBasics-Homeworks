using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.OddOrEvenSUm
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> letters = new Dictionary<char, int>() { { 'a', 1 }, { 'e', 2 }, { 'i', 3 }, { 'o', 4 }, { 'u', 5 } };
            string word = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (letters.ContainsKey(word[i]))
                {
                    sum += letters[word[i]];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
