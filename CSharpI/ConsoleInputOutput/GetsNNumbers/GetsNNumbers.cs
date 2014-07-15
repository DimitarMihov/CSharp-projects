namespace GetsNNumbers
{
    //Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 
    
    using System;

    class GetsNNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter number n:");
            int numberN = int.Parse(Console.ReadLine());
            int sum = 0;
            int numberToSum = 0;

            for (int i = 0; i < numberN; i++)
            {
                Console.Write("Enter number to sum: ");
                numberToSum = int.Parse(Console.ReadLine());
                sum += numberToSum;
            }

            Console.WriteLine("The sum of numbers is {0}", sum);
        }
    }
}
