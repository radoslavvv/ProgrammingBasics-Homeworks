using System;

namespace Logistics
{
    class Logistics
    {
        static void Main()
        {

            double goodsCount = double.Parse(Console.ReadLine());
            double totalSize = 0;
            double totalPrice = 0;

            double microbusPercentage = 0; 
            double truckPercentage = 0;
            double trainPercentage = 0;             

            for (int i = 0; i < goodsCount; i++)
            {
                double size = double.Parse(Console.ReadLine());
               
                if (size <= 3)
                {
                    totalPrice += 200 * size;
                    microbusPercentage += size;                 
                }
                else if(size >= 4 && size <=11)
                {
                    totalPrice += 175 * size;
                    truckPercentage += size;
                }
                else if(size >= 12)
                {
                    totalPrice += 120 * size;
                    trainPercentage += size;
                }

                totalSize += size;
            }
            double averageTonPrice = totalPrice / totalSize;
            microbusPercentage /= totalSize;
            truckPercentage /= totalSize;
            trainPercentage /= totalSize;

            Console.WriteLine("{0:0.00}",averageTonPrice);
            Console.WriteLine("{0:0.00}%",microbusPercentage*100);
            Console.WriteLine("{0:0.00}%", truckPercentage*100);    
            Console.WriteLine("{0:0.00}%",trainPercentage*100);


        }
    }
}
