using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        List<string> input = Console.ReadLine()
            .Split()
            .ToList();

        string result = Console.ReadLine();

        List<int> results = new List<int>();

        for (int i = 0; i < input.Count; i++)
        {
            List<int> rotationsLeft = RotateLeft(input[i]);
            List<int> rotationsRight = RotateRight(input[i]);

            if (result == "Min")
            {
                int min = Math.Min(rotationsRight.Min(), rotationsLeft.Min());
                results.Add(min);
            }
            else if (result == "Max")
            {
                int max = Math.Max(rotationsRight.Max(), rotationsLeft.Max());
                results.Add(max);
            }
        }
        Console.WriteLine($"{string.Join(", ", results)}");
        Console.WriteLine(results.Sum());
    }

    private static List<int> RotateLeft(string defaultNumberValue)
    {
        List<int> rotations = new List<int>();

        for (int i = 0; i < defaultNumberValue.Length; i++)
        {
            char[] number = defaultNumberValue.ToCharArray();

            char firstDigit = defaultNumberValue[defaultNumberValue.Length - 1];
            for (int j = number.Length - 1; j >= 1; j--)
            {
                number[j] = number[j - 1];
            }
            number[0] = firstDigit;

            string result = string.Join("", number);

            rotations.Add(int.Parse(result));
            defaultNumberValue = result;
        }
        return rotations;
    }

    private static List<int> RotateRight(string defaultNumberValue)
    {
        List<int> rotations = new List<int>();

        for (int i = 0; i < defaultNumberValue.Length; i++)
        {
            char[] number = defaultNumberValue.ToCharArray();

            char lastDigit = defaultNumberValue[0];
            for (int digit = 0; digit < defaultNumberValue.Length - 1; digit++)
            {
                number[digit] = number[digit + 1];
            }
            number[defaultNumberValue.Length - 1] = lastDigit;

            string result = string.Join("", number);

            rotations.Add(int.Parse(result));
            defaultNumberValue = result;
        }
        return rotations;
    }
}

