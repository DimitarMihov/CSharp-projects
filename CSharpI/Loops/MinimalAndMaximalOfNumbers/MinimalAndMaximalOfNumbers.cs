namespace MinimalAndMaximalOfNumbers
{
    //Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.
    
    using System;

    class MinimalAndMaximalOfNumbers
    {
        static void Main()
        {
            Console.Write("Enter the count of numbers: ");
            int count = int.Parse(Console.ReadLine());
            int[] sequenceOfNumbers = new int[count];

            for (int i = 0; i < count; i++)
            {
                Console.Write("Enter a member of sequence: ");
                sequenceOfNumbers[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(sequenceOfNumbers);

            Console.WriteLine("Minimal number is {0} and maximal is {1}", sequenceOfNumbers[0], sequenceOfNumbers[count - 1]);
        }
    }
}
