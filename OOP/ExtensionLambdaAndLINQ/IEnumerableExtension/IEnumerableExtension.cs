/*Implement a set of extension methods for IEnumerable<T> that implement
 * the following group functions: sum, product, min, max, average.
 */

using System;
using System.Collections.Generic;

public static class IEnumerableExtensions
{
    public static T Sum<T>(this IEnumerable<T> input) where T: IComparable
    {
        dynamic sum = 0;

        foreach (var item in input)
        {
            sum += item;
        }

        return sum;
    }

    public static T Product<T>(this IEnumerable<T> input) where T: IComparable
    {
        dynamic product = 1;

        foreach (var item in input)
        {
            product *= item;
        }

        return product;
    }

    public static T Min<T>(this IEnumerable<T> input) where T: IComparable
    {
        dynamic min = int.MaxValue;

        foreach (var item in input)
        {
            if (item < min)
            {
                min = item;
            }
        }

        return min;
    }

    public static T Max<T>(this IEnumerable<T> input) where T: IComparable
    {
        dynamic max = int.MinValue;

        foreach (var item in input)
        {
            if (item > max)
            {
                max = item;
            }
        }

        return max;
    }


    public static T Average<T>(this IEnumerable<T> input) where T:IComparable
    {
        dynamic lenght = 0;
        dynamic average = 0;

        foreach (var item in input)
        {
            average += item;
            lenght++;
        }

        average = average / lenght;

        return average;
    }
    
    static void Main()
    {
        int[] array = new int[10];
        Random rand = new Random();

        Console.WriteLine("Array: ");
        for (int i = 0; i < 10; i++)
        {
            array[i] = rand.Next(int.MinValue, int.MaxValue);
            Console.Write("{0}, ", array[i]);
        }

        Console.WriteLine();
        Console.WriteLine("Sum: {0}", array.Sum());
        Console.WriteLine("Product: {0}", array.Product());
        Console.WriteLine("Min value: {0}", array.Min());
        Console.WriteLine("Max value: {0}", array.Max());
        Console.WriteLine("Average: {0}", array.Average());
    }
}