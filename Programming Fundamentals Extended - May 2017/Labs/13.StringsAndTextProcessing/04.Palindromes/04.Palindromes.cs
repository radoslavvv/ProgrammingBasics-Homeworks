using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(new char[]{' ',',','!','?','.'},StringSplitOptions.RemoveEmptyEntries);


        List<string> palindromes = new List<string>();

        foreach (var word in input)
        {
            if (IsPalindrome(word))
            {
                palindromes.Add(word);
            }
        }

        Console.WriteLine($"{string.Join(", ",palindromes.OrderBy(p=>p))}");

    }

    private static bool IsPalindrome(string input)
    {
        string reversed = string.Join("", input.ToLower().ToCharArray().Reverse());
        return reversed == input.ToLower();
    }
}

