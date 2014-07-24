namespace ArrayOf20Integers
{
    //Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5. Print the obtained array on the console.
    
    using System;

    class ArrayOf20Integers
    {
        static void Main()
        {
            int[] arrayOfIntegers = new int[20];

            for (int i = 0; i < arrayOfIntegers.Length; i++)
            {
                arrayOfIntegers[i] = i * 5;
                Console.Write(arrayOfIntegers[i]);

                if (i != arrayOfIntegers.Length - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine();
        }
    }
}
