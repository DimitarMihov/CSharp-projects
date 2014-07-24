namespace CompareCharArrays
{
    //Write a program that compares two char arrays lexicographically (letter by letter).
    
    using System;

    class CompareCharArrays
    {
        static void Main()
        {
            Console.Write("Enter length of the arrays: ");
            int lengthOfTheArrays = int.Parse(Console.ReadLine());
            char[] arrayOne = new char[lengthOfTheArrays];
            char[] arrayTwo = new char[lengthOfTheArrays];
            bool areSame = true;

            Console.WriteLine("Enter elements of first array:");
            for (int i = 0; i < lengthOfTheArrays; i++)
            {
                arrayOne[i] = char.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter elements of second array:");
            for (int i = 0; i < lengthOfTheArrays; i++)
            {
                arrayTwo[i] = char.Parse(Console.ReadLine());
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
