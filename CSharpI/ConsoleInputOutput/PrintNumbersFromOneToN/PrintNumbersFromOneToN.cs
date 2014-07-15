namespace PrintNumbersFromOneToN
{
    //Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.
    
    using System;

    class PrintNumbersFromOneToN
    {
        static void Main()
        {
            Console.WriteLine("Enter number n:");
            int numberN = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberN; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
