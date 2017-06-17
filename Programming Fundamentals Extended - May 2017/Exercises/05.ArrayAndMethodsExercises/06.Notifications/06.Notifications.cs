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
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string currentLine = Console.ReadLine();

            if (currentLine == "success")
            {
                string operation = Console.ReadLine();
                string message = Console.ReadLine();
                ShowSuccess(operation, message);
            }
            else if (currentLine == "error")
            {
                string operation = Console.ReadLine();
                string code = Console.ReadLine();
                string reason = GetReason(code);

                ShowError(operation, code, reason);
            }
        }
    }

    private static string GetReason(string code)
    {
        if (int.Parse(code) > 0)
        {
            return "Invalid Client Data";
        }
        else if (int.Parse(code) < 0)
        {
            return "Internal System Failure";
        }
        else
        {
            return "";
        }

    }

    private static void ShowSuccess(string operation, string message)
    {
        Console.WriteLine($"Successfully executed {operation}.");
        Console.WriteLine("==============================");
        Console.WriteLine($"Message: {message}.");
    }

    private static void ShowError(string operation, string code, string reason)
    {
        Console.WriteLine($"Error: Failed to execute {operation}.");
        Console.WriteLine("==============================");
        Console.WriteLine($"Error Code: {code}.");
        Console.WriteLine($"Reason: {reason}.");
    }
}

