namespace BinarySearch
{
    ////Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm (find it in Wikipedia).
    
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class BinarySearch
    {
        static void Main()
        {
            int[] array = { 47, 51, 80, 72, 48, 94, 50, 57, 38, 52, 53, 77, 23, 7, 2, 64, 58, 19, 14, 35, 8, 23, 49, 21, 79, 92, 64, 22, 23, 42, 57, 81, 26, 66, 6, 55, 76, 34, 47, 86, 21, 16, 53, 62, 96, 95, 72, 70, 97, 8, 86, 9, 49, 50, 28, 68, 32, 89, 15, 73, 89, 96, 94, 96, 35, 32, 47, 1, 23, 37, 87, 55, 55, 67, 40, 85, 28, 22, 91, 94, 88, 65, 66, 25, 18, 37, 9, 27, 62, 78, 40, 73, 95, 34, 13, 74, 35, 43, 98, 49 };

            Array.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0}, ", array[i]);
            }
            
            Console.Write("Enter a value to find it's index: ");
            int valueToFind = int.Parse(Console.ReadLine());

            

            int low = 0;
            int high = array.Length - 1;
            int? foundedValue = null;
            int middle = 0;

            while (low <= high)
            {
                middle = (high + low) / 2;
                if (array[middle] == valueToFind)
                {
                    foundedValue = valueToFind;
                    break;
                }
                else if (array[middle] > valueToFind)
                {
                    high = middle - 1;
                }
                else
                {
                    low = middle + 1;
                }
            }

            if (foundedValue != null)
            {
                Console.WriteLine("Founded value is {0} at index {1}", foundedValue, middle);
            }
            else
            {
                Console.WriteLine("The value is not in array");
            }
        }
    }
}
