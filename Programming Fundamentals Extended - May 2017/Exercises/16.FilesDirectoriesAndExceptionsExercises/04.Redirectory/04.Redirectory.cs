using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Redirectory
{
    static void Main()
    {
        var directory = Directory.GetFiles("input");
        List<string> createdDirectories = new List<string>();

        foreach (var file in directory)
        {
            FileInfo info = new FileInfo(file);
            string extension = info.Extension;

            string directoryName = $"{extension.Substring(1)}s";
            if (!createdDirectories.Contains(extension))
            {
                Directory.CreateDirectory($@"output\{directoryName}");
                createdDirectories.Add(extension);
            }

            string firstLocation = file;
            string secondLocation = $@"output\{directoryName}\{file.Split('\\')[1]}";

            File.Copy($@"{firstLocation}",$@"{secondLocation}");
        }
    }
}

