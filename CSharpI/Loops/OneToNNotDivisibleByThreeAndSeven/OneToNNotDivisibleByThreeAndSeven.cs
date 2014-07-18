namespace OneToNNotDivisibleByThreeAndSeven
{
    //Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.
    
    using System;

    class OneToNNotDivisibleByThreeAndSeven
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int numberN = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberN; i++)
            {
                if (i % 3 == 0 && i % 7 == 0)
                {
                    continue;
                }

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
