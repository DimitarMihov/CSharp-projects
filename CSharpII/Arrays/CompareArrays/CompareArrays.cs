namespace CompareArrays
{
    //Write a program that reads two arrays from the console and compares them element by element.
    
    using System;

    class CompareArrays
    {
        static void Main()
        {
            Console.Write("Enter length of the arrays: ");
            int lengthOfTheArrays = int.Parse(Console.ReadLine());
            int[] arrayOne = new int[lengthOfTheArrays];
            int[] arrayTwo = new int[lengthOfTheArrays];
            bool areSame = true;

            Console.WriteLine("Enter elements of first array:");
            for (int i = 0; i < lengthOfTheArrays; i++)
            {
                arrayOne[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter elements of second array:");
            for (int i = 0; i < lengthOfTheArrays; i++)
            {
                arrayTwo[i] = int.Parse(Console.ReadLine());
            }

            for (int j = 0; j < lengthOfTheArrays; j++)
            {
                if (arrayOne[j] != arrayTwo[j])
                {
                    areSame = false;
                }
            }

            Console.WriteLine("Arrays one and two are {0}.", (areSame ? "same" : "not same"));
        }
    }
}
