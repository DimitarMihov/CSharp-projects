namespace PrintNumbersFromOneToN
{
    //Write a program that prints all the numbers from 1 to N.
    
    using System;

    class PrintNumbersFromOneToN
    {
        static void Main()
        {
            Console.Write("Enter a number N as the end of the sequence [1...N]");
            int numberN = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberN; i++)
            {
                Console.Write(i);

                if (i != numberN)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine();
        }
    }
}
