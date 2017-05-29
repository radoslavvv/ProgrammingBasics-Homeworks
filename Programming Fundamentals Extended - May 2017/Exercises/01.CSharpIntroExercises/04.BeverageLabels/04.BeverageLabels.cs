using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BeverageLabels
{
    static void Main()
    {
        string product = Console.ReadLine();
        int volume = int.Parse((Console.ReadLine()));
        int energy = int.Parse(Console.ReadLine());
        int sugar = int.Parse(Console.ReadLine());

        double quantity = volume / 100.0;

        Console.WriteLine($"{volume}ml {product}:");
        Console.WriteLine($"{energy*quantity}kcal, {sugar*quantity}g sugars");
    }
}

