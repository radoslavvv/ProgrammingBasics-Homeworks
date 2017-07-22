using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class BankAccount
{
    public string Name { get; set; }
    public string Bank { get; set; }
    public decimal Balance { get; set; }
}
class Program
{
    static void Main()
    {
        List<BankAccount> accounts = new List<BankAccount>();

        string command = Console.ReadLine();
        while (command != "end")
        {
            List<string> tokens = command.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries).ToList();

            string name = tokens[0];
            string bank = tokens[1];
            decimal balance = decimal.Parse(tokens[2]);

            BankAccount currentAccount = new BankAccount()
            {
                Name = name,
                Bank = bank,
                Balance = balance
            };

            accounts.Add(currentAccount);

            command = Console.ReadLine();
        }

        foreach (var account in accounts.OrderByDescending(a => a.Balance).ThenBy(a => a.Name.Length))
        {
            Console.WriteLine($"{account.Bank} -> {account.Balance} ({account.Name})");
        }
    }
}

