using System;
using System.Collections.Generic;

class HexadecimalToBinary
{
    //Write a program to convert hexadecimal numbers to binary numbers (directly).
    
    static void Main()
    {
        Console.Write("Please, enter a hexadecimal number: ");
        string hexNum = Console.ReadLine();

        List<string> hexList = new List<string>();
        int hexDec = 0;
        bool breakApp = false;
        foreach (var element in hexNum)
        {
            hexDec = element - 48;
            switch (hexDec)
            {
                case 0: hexList.Add("0000"); break;
                case 1: hexList.Add("0001"); break;
                case 2: hexList.Add("0010"); break;
                case 3: hexList.Add("0011"); break;
                case 4: hexList.Add("0100"); break;
                case 5: hexList.Add("0101"); break;
                case 6: hexList.Add("0110"); break;
                case 7: hexList.Add("0111"); break;
                case 8: hexList.Add("1000"); break;
                case 9: hexList.Add("1001"); break;
                case 17: hexList.Add("1010"); break;
                case 18: hexList.Add("1011"); break;
                case 19: hexList.Add("1100"); break;
                case 20: hexList.Add("1101"); break;
                case 21: hexList.Add("1110"); break;
                case 22: hexList.Add("1111"); break;

                default: breakApp = true;
                    break;
            }
        }

        if (breakApp)
        {
            Console.WriteLine("Entered number is not a hexadecimal!");
        }
        else
        {
            int n = hexList.Count;
            Console.Write("The binary equivalent of the number is: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(hexList[i]);
            }

            Console.WriteLine();
        }
    }
}
