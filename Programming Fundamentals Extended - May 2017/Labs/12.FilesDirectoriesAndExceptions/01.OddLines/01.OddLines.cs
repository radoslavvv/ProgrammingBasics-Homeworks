using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        StreamReader reader = new StreamReader("Input.txt");
        StreamWriter writer = new StreamWriter("output.txt", append: true);

        int index = 0;
        while (true)
        {
            string line = reader.ReadLine();
            if (line == null)
            {
                break;
            }

            if (index % 2 != 0)
            {
                writer.WriteLine(line);
            }
            index++;
        }
        reader.Close();
        writer.Close();
    }
}

