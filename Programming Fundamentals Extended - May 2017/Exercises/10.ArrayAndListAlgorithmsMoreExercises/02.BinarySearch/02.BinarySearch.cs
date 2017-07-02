using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int[] array = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        int searchedElement = int.Parse(Console.ReadLine());

        if (array.Contains(searchedElement))
        {
            Console.WriteLine("Yes");

           
        }
        else
        {
            Console.WriteLine("No");
        }

        int linearIterationsCount = LinearSearch(array, searchedElement);
        int binaryIterationsCount = BinarySearch(array, searchedElement);

        Console.WriteLine($"Linear search made {linearIterationsCount} iterations");
        Console.WriteLine($"Binary search made {binaryIterationsCount} iterations");
    }
    private static int LinearSearch(int[] array,int searchedElement)
    {
        int iterationsCount = 0;

        for (int i = 0; i < array.Length; i++)
        {
            iterationsCount++;
            if (array[i] == searchedElement)
            {
                break;
            }
        }
        return iterationsCount;
    }

    private static int BinarySearch(int[] array, int searchedElement)
    {
        Array.Sort(array);

        int downBoundry = 0;
        int upperBoundry = array.Length - 1;

        int iterationsCount = 0;
        bool found = false;

        while (!found)
        {
            if(upperBoundry < downBoundry)
            {
                break;
            }
            iterationsCount++;
            int middle = downBoundry +(upperBoundry - downBoundry) / 2;
            if (array[middle] < searchedElement)
            {
                downBoundry = middle  + 1;
            }
            else if(array[middle] > searchedElement)
            {
                upperBoundry = middle - 1; 
            }
            else if (array[middle] == searchedElement)
            {
                found = true;
                break;
            }
           
        }
        return iterationsCount;
    }
}
