namespace BiggestOfThreeIntegers
{
    //Write a program that finds the biggest of three integers using nested if statements.

    using System;

    class BiggestOfThreeIntegers
    {
        static void Main()
        {
            Console.WriteLine("Enter three integers:");

            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int biggestInteger;

            if (firstNumber > secondNumber)
            {
                if (firstNumber > thirdNumber)
                {
                    biggestInteger = firstNumber;
                }
                else
                {
                    biggestInteger = thirdNumber;
                }
            }
            else
            {
                if (secondNumber > thirdNumber)
                {
                    biggestInteger = secondNumber;
                }
                else
                {
                    biggestInteger = thirdNumber;
                }
            }

            Console.WriteLine("The biggest integer is: {0}", biggestInteger);
        }
    }
}
