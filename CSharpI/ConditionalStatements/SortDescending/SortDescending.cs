namespace SortDescending
{
    //Sort 3 real values in descending order using nested if statements.
    
    using System;

    class SortDescending
    {
        static void Main()
        {
            Console.WriteLine("Enter three integers:");

            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int biggestInteger;
            int mediumInteger;
            int smallerInteger;

            if (firstNumber >= secondNumber)
            {
                if (firstNumber >= thirdNumber)
                {
                    biggestInteger = firstNumber;
                    
                    if (secondNumber >= thirdNumber)
                    {
                        mediumInteger = secondNumber;
                        smallerInteger = thirdNumber;
                    }
                    else
                    {
                        mediumInteger = thirdNumber;
                        smallerInteger = secondNumber;
                    }
                }
                else
                {
                    biggestInteger = thirdNumber;
                    mediumInteger = firstNumber;
                    smallerInteger = secondNumber;
                }
            }
            else
            {
                if (secondNumber >= thirdNumber)
                {
                    biggestInteger = secondNumber;

                    if (firstNumber >= thirdNumber)
                    {
                        mediumInteger = firstNumber;
                        smallerInteger = thirdNumber;
                    }
                    else
                    {
                        mediumInteger = thirdNumber;
                        smallerInteger = firstNumber;
                    }
                }
                else
                {
                    biggestInteger = thirdNumber;
                    mediumInteger = secondNumber;
                    smallerInteger = firstNumber;
                }
            }

            Console.WriteLine("Biggest number: {0}, medium number: {1}, smaller number: {2}", biggestInteger, mediumInteger, smallerInteger);
        }
    }
}
