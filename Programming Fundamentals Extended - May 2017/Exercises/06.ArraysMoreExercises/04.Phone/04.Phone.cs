using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string[] numbers = Console.ReadLine().Split();
        string[] names = Console.ReadLine().Split();

        string command = Console.ReadLine();

        while (command != "done")
        {
            string[] action = command.Split();

            switch (action[0])
            {
                case "call":
                    Call(numbers,names,action[1]);
                    break;
                case "message":
                    Message(numbers,names,action[1]);
                    break;
            }
            command = Console.ReadLine();
        }
    }

    private static void Call(string[] numbers, string[] names, string action)
    {
        int index = 0;
        if (numbers.Contains(action))
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == action)
                {
                    index = i;
                    break;
                }
            }
            Console.WriteLine($"calling {names[index]}...");
        }
        else if (names.Contains(action))
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == action)
                {
                    index = i;
                    break;
                }
            }
            Console.WriteLine($"calling {numbers[index]}...");
        }
        int sum = GetDigitsSum(numbers, index);
        if (sum % 2 != 0)
        {
            Console.WriteLine("no answer");
        }
        else
        {
            int minutes = sum / 60;
            int seconds = sum % 60;
            Console.WriteLine($"call ended. duration: {minutes:00}:{seconds:00}");
        }
    }

    private static int GetDigitsSum(string[] numbers, int index)
    {
        string number = numbers[index];
        int digitsSum = 0;
        for (int i = 0; i < number.Length; i++)
        {
            if (number[i] >= 48 && number[i] <= 57)
            {
                digitsSum += int.Parse(number[i].ToString());
            }
        }
        return digitsSum;
    }

    private static void Message(string[] numbers, string[] names, string action)
    {
        int index = 0;
        if (numbers.Contains(action))
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == action)
                {
                    index = i;
                    break;
                }
            }
            Console.WriteLine($"sending sms to {names[index]}...");
        }
        else if (names.Contains(action))
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == action)
                {
                    index = i;
                    break;
                }
            }
            Console.WriteLine($"sending sms to {numbers[index]}...");
        }
        int diff = GetDigitsDifference(numbers, index);
        if (diff % 2 == 0)
        {
            Console.WriteLine("meet me there");
        }
        else
        {
            Console.WriteLine("busy");
        }

    }

    private static int GetDigitsDifference(string[] numbers, int index)
    {
        int diff = 0;
        string number = numbers[index];
        for (int i = 0; i < number.Length; i++)
        {
            if (number[i] >= 48 && number[i] <= 57)
            {
                diff -= number[i];
            }
        }
        return diff;
    }
}

