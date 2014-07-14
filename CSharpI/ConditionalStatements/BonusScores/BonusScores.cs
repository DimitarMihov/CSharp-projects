namespace BonusScores
{
    //Write a program that applies bonus scores to given scores in the range [1..9].
    //The program reads a digit as an input. If the digit is between 1 and 3, the program multiplies it by 10;
    //if it is between 4 and 6, multiplies it by 100; if it is between 7 and 9, multiplies it by 1000.
    //If it is zero or if the value is not a digit, the program must report an error.
    //Use a switch statement and at the end print the calculated new value in the console.

    
    using System;

    class BonusScores
    {
        static void Main()
        {
            Console.Write("Enter a digit: ");
            bool isDigit = false;
            int digit = -1;

            while (isDigit == false)
            {
                isDigit = int.TryParse(Console.ReadLine(), out digit);
                if (isDigit == false)
                {
                    Console.WriteLine("Entered value is not a digit. Enter a digit: ");
                }
            }

            switch (digit)
            {
                case 1:
                case 2:
                case 3:
                    digit *= 10;
                    break;
                case 4:
                case 5:
                case 6:
                    digit *= 100;
                    break;
                case 7:
                case 8:
                case 9:
                    digit *= 1000;
                    break;
                case 0:
                default:
                    digit = -1;
                    
                    break;
            }

            if (digit == -1)
            {
                Console.WriteLine("The number is not in range [1 ... 9]");
            }
            else
            {
                Console.WriteLine("Calculated new value is: {0}", digit);
            }
        }
    }
}
