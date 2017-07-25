using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        StreamReader reader = new  StreamReader("input1.txt");
        StreamReader secondReader = new StreamReader("input2.txt");
        StreamWriter writer = new StreamWriter("output.txt",append:true);

        while (true)
        {
            string line = reader.ReadLine();
            if (line == null) break;
            writer.WriteLine(line);


            string secondLine = secondReader.ReadLine();
            if (secondLine == null) break;
            writer.WriteLine(secondLine);
        }

        reader.Close();
        writer.Close();
        secondReader.Close();
    }
}

