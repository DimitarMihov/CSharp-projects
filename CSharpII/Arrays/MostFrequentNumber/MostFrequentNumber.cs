namespace MostFrequentNumber
{
    ////Write a program that finds the most frequent number in an array. Example:
	////{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} -> 4 (5 times)
    
    using System;

    class MostFrequentNumber
    {
        static void Main()
        {
            int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            int frequentNumber = 0;
            int repeating = 1;
            int mostFrequentNumber = 0;
            int maxRepeating = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        frequentNumber = array[i];
                        repeating++;
                    }
                }

                if (maxRepeating < repeating)
                {
                    maxRepeating = repeating;
                    mostFrequentNumber = frequentNumber;
                }

                repeating = 1;
            }

            Console.WriteLine("Most frequent number is {0}, repeated {1} times.", mostFrequentNumber, maxRepeating);
        }
    }
}
