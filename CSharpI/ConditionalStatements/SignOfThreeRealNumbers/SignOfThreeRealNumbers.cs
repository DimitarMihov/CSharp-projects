namespace SignOfThreeRealNumbers
{
    //Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if statements.
    
    using System;

    class SignOfThreeRealNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter three real numbers:");

            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            bool isNegative = true;

            if (firstNumber >= 0)
            {
                if (secondNumber >= 0)
                {
                    if (thirdNumber >= 0)
                    {
                        isNegative = false;
                    }
                }
                else
                {
                    if (thirdNumber < 0)
                    {
                        isNegative = false;
                    }
                }
            }
            else
            {
                if (secondNumber >= 0)
                {
                    if (thirdNumber < 0)
                    {
                        isNegative = false;
                    }
                }
                else
                {
                    if (thirdNumber >= 0)
                    {
                        isNegative = false;
                    }
                }
            }

            if (isNegative)
            {
                Console.WriteLine("The product is with sign '-'");
            }
            else
            {
                Console.WriteLine("The product is with sign '+'");
            }
        }
    }
}
