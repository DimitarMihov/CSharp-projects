namespace GreaterOfTwoNumbers
{
    //Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.
    
    using System;

    class GreaterOfTwoNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter two numbers:");
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int greaterNumber = Math.Max(firstNumber, secondNumber);

            Console.WriteLine("The greater number is {0}", greaterNumber);
        }
    }
}
