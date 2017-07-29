using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class User
{
    public string Name { get; set; }
    public string Pass { get; set; }
    public bool IsLogedIn { get; set; }      
}

class UserDatabase
{
    static void Main()
    {
        var reader = new StreamReader("users.txt");
        var users = new List<User>();

        string userLine = reader.ReadLine();
        while (userLine != null && userLine != "exit")
        {
            string[] split = userLine.Split();
            string username = split[0];
            string pass = split[1];
            bool isLogedIn = bool.Parse(split[2]);

            User currentUser = new User()
            {
                Name = username,
                Pass = pass,
                IsLogedIn = isLogedIn
            };

            users.Add(currentUser);
            userLine = reader.ReadLine();
        }
        reader.Close();
        reader = new StreamReader("input.txt");
        StreamWriter writer = new StreamWriter("output.txt", append: true);
        string line = "";
        while (line != "exit")
        {
            string[] tokens = line.Split();

            if (tokens[0] == "register")
            {
                string username = tokens[1];
                string pass = tokens[2];
                string confirmPass = tokens[3];

                if (users.Any(u => u.Name == username))
                {
                    writer.WriteLine($"The given username already exists.");
                }
                else if (pass != confirmPass)
                {
                    writer.WriteLine($"The two passwords must match.");
                }
                else
                {
                    User currentUser = new User()
                    {
                        Name = username,
                        Pass = pass
                    };
                    users.Add(currentUser);
                }
            }
            else if (tokens[0] == "login")
            {
                if (users.All(u => u.Name != tokens[1]))
                {
                    writer.WriteLine($"There is no user with the given username.");
                }
                else if (users.Single(u => u.Name == tokens[1]).IsLogedIn)
                {
                    writer.WriteLine($"There is already a logged in user.");
                }
                else if (users.Single(u => u.Name == tokens[1]).Pass != tokens[2])
                {
                    writer.WriteLine($"The password you entered is incorrect.");
                }
                else
                {
                    users.Single(u => u.Name == tokens[1]).IsLogedIn = true;
                }
            }
            else if (tokens[0] == "logout")
            {
                if (users.All(u => u.IsLogedIn == false))
                {
                    writer.WriteLine($"There is no currently loged in user.");
                }
                else
                {
                    users.Single(u => u.IsLogedIn == true).IsLogedIn = false;
                }
            }
            line = reader.ReadLine();
        }

        reader.Close();
        writer.Close();

        writer = new StreamWriter("users.txt");
        foreach (var user in users)
        {
            writer.WriteLine($"{user.Name} {user.Pass} {user.IsLogedIn}");
        }
        writer.WriteLine("exit");
        writer.Close();
    }


}

