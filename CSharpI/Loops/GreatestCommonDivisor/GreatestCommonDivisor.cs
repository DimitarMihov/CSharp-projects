namespace GreatestCommonDivisor
{
    //Write a program that calculates the greatest common divisor (GCD) of given two numbers. Use the Euclidean algorithm (find it in Internet).
    
    using System;

    class GreatestCommonDivisor
    {
        static void Main()
        {
            Console.Write("Enter 'a': ");
            double numberA = double.Parse(Console.ReadLine());
            Console.Write("Enter 'b': ");
            double numberB = double.Parse(Console.ReadLine());
            double gcd;

            if (numberB == 0)
            {
                gcd = numberA;
            }
            else
            {
                while (numberB != 0)
                {
                    double aModB = numberA % numberB;
                    numberA = numberB;
                    numberB = aModB;
                }

                gcd = numberA;
            }

            Console.WriteLine("The greatest common divisor is {0}", gcd);
        }
    }
}
