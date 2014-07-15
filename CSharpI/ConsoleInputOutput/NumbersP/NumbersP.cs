namespace NumbersP
{
    //Write a program that reads two positive integer numbers and prints how many numbers p exist between them
    //such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.

    
    using System;

    class NumbersP
    {
        static void Main()
        {
            Console.WriteLine("Enter two numbers:");
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int result = (secondNumber - firstNumber) / 5 + 1;

            Console.WriteLine(result);
        }
    }
}
