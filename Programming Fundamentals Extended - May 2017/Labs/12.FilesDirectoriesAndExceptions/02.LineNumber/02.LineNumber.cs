using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        StreamReader reader = new StreamReader("Input.txt");
        StreamWriter writer = new StreamWriter("Output.txt",append:true);

        int index = 1;
        while (true)
        {
            string line = reader.ReadLine();
            if (line == null) break;
            writer.WriteLine($"{index}. {line}");
            index++;
        }

        reader.Close();
        writer.Close();
    }
}

