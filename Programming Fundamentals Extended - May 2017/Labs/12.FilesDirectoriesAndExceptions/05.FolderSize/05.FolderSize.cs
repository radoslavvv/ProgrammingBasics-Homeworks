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
        string[] files = Directory.GetFiles(@"C:\Users\monop\OneDrive\documents\visual studio 2017\Projects\22.FilesDirectoriesAndExceptions\05.FolderSize\bin\TestFolder");

        double sum = 0;
        foreach (var file in files)
        {
            FileInfo info = new FileInfo(file);
            sum += info.Length;
        }
        Console.WriteLine(sum/1024/1024);
    }
}

