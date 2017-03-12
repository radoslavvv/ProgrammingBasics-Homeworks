using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal collectedMoney = decimal.Parse(Console.ReadLine());
            decimal floorWidth = decimal.Parse(Console.ReadLine());
            decimal floorLenght = decimal.Parse(Console.ReadLine());
            decimal triangleSide = decimal.Parse(Console.ReadLine());
            decimal triangleHeight = decimal.Parse(Console.ReadLine());
            decimal tilePrice = decimal.Parse(Console.ReadLine());
            decimal workerPrice = decimal.Parse(Console.ReadLine());

            decimal area = floorLenght * floorWidth;
            decimal tileArea = triangleSide * triangleHeight / 2m;
            decimal tilesNeeded = Math.Ceiling(area / tileArea)+5;
            decimal totalPrice = (tilesNeeded * tilePrice) + workerPrice;

            if(collectedMoney < totalPrice)
            {
                Console.WriteLine("You'll need {0:0.00} lv more.",totalPrice - collectedMoney);

            }
            else
            {
                Console.WriteLine("{0:0.00} lv left.",collectedMoney -totalPrice);
            }


        }
    }
}
