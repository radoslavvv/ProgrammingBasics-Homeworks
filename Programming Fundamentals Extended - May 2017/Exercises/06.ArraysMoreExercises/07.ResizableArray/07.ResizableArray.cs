using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string[] array = new string[4];

        string command = Console.ReadLine();
        
        while (command != "end")
        {
            string[] arguments = command.Split();

            switch (arguments[0])
            {
                case "push":
                    array = Push( array, arguments[1]);
                    break;
                case "pop":
                    Pop(array);
                    break;
                case "clear":
                    Clear(array);
                    break;
                case "removeAt":
                    RemoveAt(array, int.Parse(arguments[1]));
                    break;
            }
            command = Console.ReadLine();
        }
        foreach (var number in array)
        {
            if (array.All(n => n == null))
            {
                Console.WriteLine("empty array");
                break;
            }
            if (number != null)
            {
                Console.Write($"{number} ");
            }
        }
    }

    private static string[] Push(string[] array, string number)
    {
        bool pushed = false;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == null)
            {
                array[i] = number;
                pushed = true;
                break;
            }
        }
        if (pushed == false)
        {
            string[] newArray = new string[array.Length * 2];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            newArray[array.Length] = number;
            return newArray;
        }
        return array;
    }
    private static void Pop(string[] array)
    {
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] != null)
            {
                array[i] = null;
                break;
            }
        }
    }
    private static void Clear(string[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = null;
        }
    }
    private static void RemoveAt(string[] array, int number)
    {
        array[number] = null;
        for (int i = number; i < array.Length - 1; i++)
        {
            array[i] = array[i + 1];
        }
        array[array.Length - 1] = null;
    }
}

