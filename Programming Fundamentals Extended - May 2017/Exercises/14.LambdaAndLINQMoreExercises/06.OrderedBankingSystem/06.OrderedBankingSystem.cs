using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Dictionary<string, Dictionary<string, decimal>> banks = new Dictionary<string, Dictionary<string, decimal>>();

        string input = Console.ReadLine();
        while (input != "end")
        {
            string[] split = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            string bank = split[0];
            string account = split[1];
            decimal balance = decimal.Parse(split[2]);

            AddBalance(banks, bank, account, balance);

            input = Console.ReadLine();
        }

        PrintResults(banks);
    }

    private static void AddBalance(Dictionary<string, Dictionary<string, decimal>> banks, string bank, string account, decimal balance)
    {
        if (!banks.ContainsKey(bank))
        {
            banks.Add(bank, new Dictionary<string, decimal>());
        }
        if (!banks[bank].ContainsKey(account))
        {
            banks[bank].Add(account, 0);
        }
        banks[bank][account] += balance;
    }

    private static void PrintResults(Dictionary<string, Dictionary<string, decimal>> banks)
    {
        foreach (var bank in banks.OrderByDescending(b => b.Value.Values.Sum())
                    .ThenByDescending(b => b.Value.Values.Max()))
        {
            foreach (var account in bank.Value.OrderByDescending(a => a.Value))
            {
                Console.WriteLine($"{account.Key} -> {account.Value} ({bank.Key})");
            }
        }
    }
}

