namespace NthCatalanNumber
{
    //Write a program to calculate the Nth Catalan number by given N.
    
    using System;

    class NthCatalanNumber
    {
        static void Main()
        {
            Console.Write("Enter number for Nth Catalan number equal or greater than zero: ");
            double nthNumber = double.Parse(Console.ReadLine());

            while (true)
            {
                if (nthNumber >= 0)
                {
                    break;
                }

                Console.Write("Enter number equal or greater than zero: ");
                nthNumber = double.Parse(Console.ReadLine());
            }

            double divident = 1;
            double divisor = 0;
            double divisorA = 1;
            double divisorB = 1;
            double catalanNumber = 0;

            for (int i = 1; i <= 2 * nthNumber; i++)
            {
                divident *= i;
            }

            for (int i = 1; i <= nthNumber + 1; i++)
            {
                divisorA *= i;
            }

            for (int i = 1; i <= nthNumber; i++)
            {
                divisorB *= i;
            }

            divisor = divisorA * divisorB;
            catalanNumber = divident / divisor;

            Console.WriteLine("The Nth Catalan number is {0}", catalanNumber);
        }
    }
}
