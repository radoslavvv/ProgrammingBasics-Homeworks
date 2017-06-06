using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        ulong firstNumber = ulong.Parse(Console.ReadLine());
        ulong secondNumber = ulong.Parse(Console.ReadLine());

        string firstType = GetType(firstNumber);
        string secondType = GetType(secondNumber);

        string biggerType = "";
        string smallerType = "";

        if (firstNumber > secondNumber)
        {
            biggerType = firstType;
            smallerType = secondType;

        }
        else
        {
            biggerType = secondType;
            smallerType = firstType;
        }
        ulong biggerNumber = 0;
        ulong smallerNumber = 0;

        if (firstNumber > secondNumber)
        {
            biggerNumber = firstNumber;
            smallerNumber = secondNumber;
        }
        else
        {
            biggerNumber = secondNumber;
            smallerNumber = firstNumber;
        }
        Console.WriteLine($"bigger type: {biggerType}");
        Console.WriteLine($"smaller type: {smallerType}");


        if (smallerType == "byte")
        {
            Console.WriteLine($"{biggerNumber} can overflow byte {Math.Round(biggerNumber / (decimal)byte.MaxValue,0)} times");
        }
        else if (smallerType == "ushort")
        {
            Console.WriteLine($"{biggerNumber} can overflow ushort {Math.Round(biggerNumber / (decimal)ushort.MaxValue,0)} times");
        }
        else if (smallerType == "uint")
        {
            Console.WriteLine($"{biggerNumber} can oveflow uint {Math.Round(biggerNumber / (decimal)uint.MaxValue,0)} times");
        }
        else if (smallerType == "ulong")
        {
            Console.WriteLine($"{biggerNumber} can overflow ulong {Math.Round(biggerNumber / (decimal)ulong.MaxValue,0)} times");
        }
    }

    public static string GetType(ulong number)
    {
        bool isByte = number >= byte.MinValue && number <= byte.MaxValue;
        bool isUshort = number >= ushort.MinValue && number <= ushort.MaxValue;
        bool isUint = number >= uint.MinValue && number <= uint.MaxValue;
        bool isUlong = number >= ulong.MinValue && number <= ulong.MaxValue;

        if (isByte)
        {
            return "byte";
        }
        else if (isUshort)
        {
            return "ushort";
        }
        else if (isUint)
        {
            return "uint";
        }
        else
        {
            return "ulong";
        }
    }


}