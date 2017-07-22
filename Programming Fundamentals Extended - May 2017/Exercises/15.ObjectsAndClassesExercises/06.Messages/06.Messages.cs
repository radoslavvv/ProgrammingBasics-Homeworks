using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class User
{
    public string Username { get; set; }
    public List<Message> RecievedMessages { get; set; }
}

class Message
{
    public string Content { get; set; }
    public string Sender { get; set; }
}

class Program
{
    static void Main()
    {
        List<User> users = new List<User>();
        string input = Console.ReadLine();

        while (input != "exit")
        {
            string[] tokens = input.Split();
            if (tokens[0] == "register")
            {
                RegisterUser(users, tokens);
            }
            else
            {
                SendMessage(users, input, tokens);
            }

            input = Console.ReadLine();
        }
        string[] usernames = Console.ReadLine().Split();

        List<Message> secondUser = users.Single(u => u.Username == usernames[0]).RecievedMessages
            .Where(s => s.Sender == usernames[1]).ToList();

        List<Message> firstUser = users.Single(u => u.Username == usernames[1]).RecievedMessages
            .Where(s => s.Sender == usernames[0]).ToList();

        if (firstUser.Count == 0 && secondUser.Count == 0)
        {
            Console.WriteLine($"No messages");
        }
        else
        {
            Print(firstUser, secondUser);
        }
    }

    private static void SendMessage(List<User> users, string input, string[] tokens)
    {
        string sender = tokens[0];
        string recipient = tokens[2];
        string content = input.Substring(sender.Length + 6 + recipient.Length + 1);

        if (users.Any(u => u.Username == sender) && users.Any(u => u.Username == recipient))
        {
            Message currentMessage = new Message()
            {
                Sender = sender,
                Content = content
            };
            users.Single(u => u.Username == recipient).RecievedMessages.Add(currentMessage);
        }
    }

    private static void RegisterUser(List<User> users, string[] tokens)
    {
        if (users.All(u => u.Username != tokens[1]))
        {
            User currentUser = new User()
            {
                Username = tokens[1],
                RecievedMessages = new List<Message>()
            };
            users.Add(currentUser);
        }
    }

    private static void Print(List<Message> firstList, List<Message> secondList)
    {
        string firstUser = firstList.Count > 0 ? firstList[0].Sender : "";
        string secondUser = secondList.Count > 0 ? secondList[0].Sender : "";

        int index = 0;
        while (index < firstList.Count && index < secondList.Count)
        {
            Console.WriteLine($"{firstUser}: {firstList[index].Content}");
            Console.WriteLine($"{secondList[index].Content} :{secondUser}");
            index++;
        }

        while (index < firstList.Count)
        {
            Console.WriteLine($"{firstUser}: {firstList[index].Content}");
            index++;
        }

        while (index < secondList.Count)
        {
            Console.WriteLine($"{secondList[index].Content} :{secondUser}");
            index++;
        }
    }
}

