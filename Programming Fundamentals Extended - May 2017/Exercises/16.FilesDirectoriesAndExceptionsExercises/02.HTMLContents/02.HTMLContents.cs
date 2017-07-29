using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class HTMLcontents
{
    static void Main()
    {
        string input = Console.ReadLine();
        List<KeyValuePair<string,string>> tags = new List<KeyValuePair<string, string>>();
        while (input != "exit")
        {
            string[] tokens = input.Split();
            KeyValuePair<string,string> currentPair = new KeyValuePair<string, string>(tokens[0],tokens[1]);

            tags.Add(currentPair);


            input = Console.ReadLine();
        }

        StreamWriter writer = new StreamWriter("index.html",append:true);

        writer.WriteLine($@"
<!DOCTYPE html>
    <html>
    <head>
        <title>{tags.Last(t => t.Key == "title").Value}</ title>
    </head>
    <body>
    ");
        foreach (var tag in tags.Where(t=>t.Key !="title"))
        {
            writer.WriteLine($"    <{tag.Key}>{tag.Value}</{tag.Key}>");
        }
        writer.WriteLine($@"
    </body>
    </html>");
        writer.Close();
    }
}

