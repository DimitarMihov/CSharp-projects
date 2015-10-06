using System;

class SquareRoot
{
    /*Write a program that reads an integer number and calculates and prints its square root. 
    If the number is invalid or negative, print "Invalid number". 
    In all cases finally print "Good bye". Use try-catch-finally.*/

    static void Main()
    {
        Console.Write("Please, enter a number: ");
        try
        {
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                throw new Exception();
            }
            number = (int)Math.Sqrt(number);
            Console.WriteLine("The square root of entered number is {0}", number);

        }
        catch (Exception)
        {

            Console.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Goog bye!");
        }
    }
}
