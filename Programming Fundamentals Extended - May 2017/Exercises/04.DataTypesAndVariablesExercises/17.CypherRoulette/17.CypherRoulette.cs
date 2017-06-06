using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string result = "";
        bool isSpinned = false;
        string previousWord = "";

        for (int i = 0; i < n; i++)
        {
            string currentWord = Console.ReadLine();

            if (currentWord == "spin")
            {
                i--;
                if (currentWord == previousWord)
                {
                    result = "";
                    previousWord = currentWord;
                    continue;
                }
                isSpinned = !isSpinned;
                previousWord = currentWord;
                continue;
            }
            if (currentWord == previousWord)
            {
                result = "";
                continue;
            }
            if (isSpinned)
            {
                result = result.Insert(0, currentWord);
            }
            else
            {
                result = result.Insert(result.Length, currentWord);
            }

            previousWord = currentWord;
        }
        Console.WriteLine(result);
    }
}

