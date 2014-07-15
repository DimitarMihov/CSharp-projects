namespace ReadAndPrintNumbers
{
    //Write a program that reads 3 integer numbers from the console and prints their sum.
    
    using System;

    class ReadAndPrintNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter three integer numbers:");

            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int sumOfNumbers = firstNumber + secondNumber + thirdNumber;

            Console.WriteLine(sumOfNumbers);

        }
    }
}
