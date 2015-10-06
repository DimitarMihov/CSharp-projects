/*You are given an array of strings. Write a method that sorts the array
 * by the length of its elements (the number of characters composing them).
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class SortLenghtOfElements
{
    static void Main()
    {
        string[] stringArr = { "abcde", "mno", "prqs", "tgones", "ah" };

        SortSize(stringArr);
    }

    static void SortSize(string[] stringArr)
    {
        int n = stringArr.Length;
        int[] sizes = new int[n];

        for (int i = 0; i < n; i++)
        {
            sizes[i] = stringArr[i].Length;
        }

        Array.Sort(sizes, stringArr);

        foreach (var element in stringArr)
        {
            Console.WriteLine(element);
        }


    }
}


