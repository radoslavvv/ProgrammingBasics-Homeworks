using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Fishland
{
    static void Main()
    {
        decimal skumriqPrice = decimal.Parse(Console.ReadLine());
        decimal cacaPrice = decimal.Parse(Console.ReadLine());
        decimal palamudKilograms = decimal.Parse(Console.ReadLine());
        decimal safridKilograms = decimal.Parse(Console.ReadLine());
        decimal midiKilograms = decimal.Parse(Console.ReadLine());

        decimal palamudPrice = skumriqPrice + (skumriqPrice * 0.60m);
        decimal safridPrice = cacaPrice + (cacaPrice * 0.80m);
        decimal midiPrice = 7.50m;

        decimal totalPrice = (palamudPrice * palamudKilograms) + (safridPrice * safridKilograms) + (midiPrice * midiKilograms);

        Console.WriteLine("{0:0.00}", totalPrice);
    }
}



