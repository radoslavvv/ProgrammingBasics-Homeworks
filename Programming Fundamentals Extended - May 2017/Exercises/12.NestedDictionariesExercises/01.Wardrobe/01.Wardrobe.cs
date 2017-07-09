using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int linesCount = int.Parse(Console.ReadLine());
        Dictionary<string,Dictionary<string,int>> wardrobe = new Dictionary<string, Dictionary<string,int>>();
  
        for (int i = 0; i < linesCount; i++)
        {
            string input = Console.ReadLine();
            List<string> tokens = input
                .Split(new string[]{" -> ",},StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string color = tokens[0];
            List<string> clothes = tokens[1]
                .Split(new char[]{','},StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            if (!wardrobe.ContainsKey(color))
            {
                wardrobe[color] = new Dictionary<string, int>();
            }
            foreach (var cloth in clothes)
            {
                if (!wardrobe[color].ContainsKey(cloth))
                {
                    wardrobe[color][cloth] = 0;
                }
                wardrobe[color][cloth]++;
            }
        }
        string searched = Console.ReadLine();
        string searchedColor = searched.Split()[0];
        string searchedCloth = searched.Split()[1];

        foreach (var color in wardrobe)
        {
            Console.WriteLine($"{color.Key} clothes:");
            foreach (var cloth in color.Value)
            {
                if (cloth.Key == searchedCloth && color.Key == searchedColor)
                {
                    Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    
                }
                else
                {
                    Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                }
            }
        }
    }
}

