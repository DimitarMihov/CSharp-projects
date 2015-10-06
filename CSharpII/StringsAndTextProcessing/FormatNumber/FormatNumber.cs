using System;

class FormatNumber
{
    /*Write a program that reads a number and prints it as a decimal
     * number, hexadecimal number, percentage and in scientific notation.
     * Format the output aligned right in 15 symbols.*/
    
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Decimal: \t{0,15:d}\nHexadecimal: \t{0,15:X}\nPercentage: \t{0,15:P}\nScientific: \t{0,15:E}", number);
    }
}
