namespace SelectionSort
{
    ////Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
    ////Use the "selection sort" algorithm: Find the smallest element, move it at the first position,
    ////find the smallest from the rest, move it at the second position, etc.
    
    using System;

    class SelectionSort
    {
        static void Main()
        {
            Console.WriteLine("Enter members of array separated by comma:");
            string arrayAsString = Console.ReadLine();
            string[] splittedArrayAsString = arrayAsString.Split(',');
            int[] arrayToSort = new int[splittedArrayAsString.Length];

            for (int i = 0; i < splittedArrayAsString.Length; i++)
            {
                arrayToSort[i] = int.Parse(splittedArrayAsString[i]);
            }

            int smallestNumber = int.MaxValue;
            int index = 0;

            for (int i = 0; i < arrayToSort.Length; i++)
            {
                for (int j = i; j < arrayToSort.Length; j++)
                {
                    if (smallestNumber > arrayToSort[j])
                    {
                        smallestNumber = arrayToSort[j];
                        index = j;
                    }
                }

                arrayToSort[index] = arrayToSort[i];
                arrayToSort[i] = smallestNumber;
                smallestNumber = int.MaxValue;
            }


            Console.WriteLine("Sorted array is:");
            for (int i = 0; i < arrayToSort.Length; i++)
            {
                Console.Write(arrayToSort[i]);

                if (i != arrayToSort.Length - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine();
        }
    }
}
