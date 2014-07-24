namespace ElementsWithMaximalSum
{
    //Write a program that reads two integer numbers N and K and an array of N elements from the console.
    //Find in the array those K elements that have maximal sum.
    
    using System;
    using System.Collections.Generic;

    class ElementsWithMaximalSum
    {
        static void Main()
        {
            Console.Write("Enter number of elements in an array: ");
            int numberOfElements = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter elements of the array:");
            int[] arrayOfElements = new int[numberOfElements];

            for (int i = 0; i < numberOfElements; i++)
            {
                arrayOfElements[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter number of sequnce with maximal sum: ");
            int numberOfSequence = int.Parse(Console.ReadLine());

            List<int> sequence = new List<int>();
            int sumOfSequence = 0;
            List<int> buffer = new List<int>();
            int sumOfBuffer = 0;

            for (int i = 0; i < numberOfElements - (numberOfSequence - 1); i++)
            {
                for (int j = i; j < numberOfSequence + i; j++)
                {
                    buffer.Add(arrayOfElements[j]);
                    sumOfBuffer += arrayOfElements[j];
                }

                if (sumOfBuffer > sumOfSequence)
                {
                    sequence.Clear();
                    sequence.AddRange(buffer);
                    sumOfSequence = sumOfBuffer;
                }

                buffer.Clear();
                sumOfBuffer = 0;
            }

            foreach (var item in sequence)
            {
                Console.Write("{0}, ", item);
            }
        }
    }
}
