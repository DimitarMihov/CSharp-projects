/*Write a program, that reads from the console an array of N integers
 * and an integer K, sorts the array and using the method Array.BinSearch()
 * finds the largest number in the array which is ≤ K. 
*/

using System;

class BinSearch
{
    static void Main()
    {
        Console.WriteLine("Enter the number of elements: ");
        int n = int.Parse(Console.ReadLine());
        int[] num = new int[n];

        Console.WriteLine("Enter elements: ");
        for (int i = 0; i < num.Length; i++)
        {
            num[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Please enter K:");
        int k = int.Parse(Console.ReadLine());


        Array.Sort(num);
        int index = Array.BinarySearch(num, k);

        if (num[0] > k)
        {
            Console.WriteLine("There isn't such a number in the array.");
        }
        else
        {
            if (index >= 0)
            {
                Console.WriteLine("The largest number in the array which is less or equal to K is {0}", num[index]);
            }
            else
            {
                Console.WriteLine("The largest number in the array which is less or equal to K is {0}", num[-index - 2]);
            }
        }
    }
}

