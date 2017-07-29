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
        string extension = Console.ReadLine();
        var directory = Directory.GetFiles("input");
        foreach (var file in directory)
        {
            FileInfo info = new FileInfo(file);
            if (info.Extension == "."+extension)
            {
                Console.WriteLine(info.Name);
            }
        }
    }
}

