using System;
using System.Collections.Generic;

class DecimalToHexadecimalConversion
{
    //Write a program to convert decimal numbers to their hexadecimal representation.
    
    static void Main()
    {
        char[] hexDec = new char[] {'0','1','2','3','4','5','6','7','8','9','A','B','C','D','E','F'};
        Console.Write("Please, enter a decimal number: ");
        int decNum = int.Parse(Console.ReadLine());

        List<char> hexaDecimal = new List<char>();
        int hexNum = 0;
        char element = ' ';
        while (decNum > 0)
        {
            hexNum = (decNum % 16);
            element = hexDec[hexNum];
            hexaDecimal.Add(element);
            decNum = decNum / 16;
        }

        hexaDecimal.Reverse();
        Console.Write("The hexadecimal number is: ");
        foreach (var member in hexaDecimal)
        {
            Console.Write(member);
        }
        Console.WriteLine();
    }
}
