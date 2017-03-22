using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Bills
{
    static void Main()
    {
        double waterMonthly = 20;
        double internetMonthly = 15;
        double electricityMonthly = 0;
        double otherMontly = 0;

        double electricityTotal = 0;
        double internetTotal = 0;
        double waterTotal = 0;
        double otherTotal = 0;

        int monthsCount = int.Parse(Console.ReadLine());
        double totalBill = 0;

        for (int i = 0; i < monthsCount; i++)
        {
            electricityMonthly = double.Parse(Console.ReadLine());

            electricityTotal += electricityMonthly;
            waterTotal += waterMonthly;
            internetTotal += internetMonthly;

            otherMontly = (waterMonthly + internetMonthly + electricityMonthly);
            otherMontly += otherMontly * 0.20;
            otherTotal += otherMontly;

            totalBill += waterMonthly + electricityMonthly + internetMonthly + otherMontly;
        }
        Console.WriteLine("Electricity: {0:0.00} lv", electricityTotal);
        Console.WriteLine("Water: {0:0.00} lv", waterTotal);
        Console.WriteLine("Internet: {0:0.00} lv", internetTotal);
        Console.WriteLine("Other: {0:0.00} lv", otherTotal);
        Console.WriteLine("Average: {0:0.00} lv", totalBill / monthsCount);
    }
}

